using System;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmpGrfLAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool loaded = false;
        List<List<Triangles>> triangles = new List<List<Triangles>>();
        List<Triangles> triangl = new List<Triangles>();
        List<points> tmp_point = new List<points>();
        int N_set = 0, index = 0;
        Color CurColor = Color.Yellow;//текущий цвет
        bool Paint_or_Move = true; //рисовать, если true,перемещение, если false
        bool Active = false;//true-выбран примитив
        bool Smooth = false;//true-есть сглаживание
        int dx = 0, dy = 0, x_offset, y_offset;
        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.White);
            SetupViewport();
            triangles.Add(new List<Triangles>());
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            timer1.Start();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
            SetupViewport();
        }

        private void SetupViewport()
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1); // Верхний левый угол имеет кооординаты(0, 0)
            GL.Viewport(0, 0, w, h); // Использовать всю поверхность GLControl под рисование
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;
            glControl1.SwapBuffers();
            GL.ClearColor(Color.White);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.PointSize(6);
            if(Smooth)
                GL.Enable(EnableCap.LineSmooth);
            GL.Begin(PrimitiveType.Triangles);
            foreach (List<Triangles> trian in triangles)//отрисовка примитивов
            {
                foreach (Triangles tr in trian)
                {  
                    GL.Color3(Color.FromArgb(tr.red, tr.green, tr.blue));
                    GL.Vertex2(tr.a.x, tr.a.y);
                    GL.Vertex2(tr.b.x, tr.b.y);
                    GL.Vertex2(tr.c.x, tr.c.y);
                }
            }
            GL.End();
            if(Smooth)
                GL.Disable(EnableCap.LineSmooth);
            if(Smooth)
                GL.Enable(EnableCap.PointSmooth);//сглаживание точек
            GL.Begin(PrimitiveType.Points);
            foreach (points pt in tmp_point)//отрисовка примитива
            {
                GL.Color3(Color.Violet);
                GL.Vertex2(pt.x, pt.y);
            }
            if(Active)
                foreach(Triangles tr in triangles[index])
                {
                    GL.PointSize(8);
                    GL.Color3(Color.Black);
                    GL.Vertex2(tr.a.x, tr.a.y);
                    GL.Vertex2(tr.b.x, tr.b.y);
                    GL.Vertex2(tr.c.x, tr.c.y);
                }
            GL.End();
            if(Smooth)
                GL.Disable(EnableCap.PointSmooth);
        }

        private void glControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(Paint_or_Move)
            if (e.Button == MouseButtons.Left)//добавление примитивов
            {
                int x = e.X, y = glControl1.Height - e.Y,
                red = CurColor.R, green = CurColor.G, blue = CurColor.B;
                if (tmp_point.Count == 2)
                {
                    tmp_point.Add(new points(x, y, red, green, blue));
                    triangles[N_set].Add(new Triangles(tmp_point[0], tmp_point[1], tmp_point[2], red, green, blue));
                    tmp_point.Clear();
                }
                else
                    tmp_point.Add(new points(x, y, red, green, blue));
            }
            if (e.Button == MouseButtons.Right)//завершение набора
            {
                N_set++;
                triangles.Add(new List<Triangles>());
                listBox1.Items.Add("Set №" + N_set.ToString());
            }
            if (e.Button == MouseButtons.Middle)
            {

                if (Paint_or_Move)
                {
                    Paint_or_Move = false;
                    Mode.Text = "selected move mode";
                }
                else
                {
                    Paint_or_Move = true;
                    Mode.Text = "selected drawing mode";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//перерисовка по таймеру
        {
            glControl1.Invalidate();
        }

        private void color_Click(object sender, EventArgs e)//выбор цвета
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (listBox1.SelectedIndices.Count != 0 && Active)
                    foreach (Triangles tr in triangles[listBox1.SelectedIndex])
                    {
                        tr.red = colorDialog1.Color.R;
                        tr.green = colorDialog1.Color.G;
                        tr.blue = colorDialog1.Color.B;
                    }
                CurColor = colorDialog1.Color;
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            var ind=listBox1.SelectedIndices;
            while(ind.Count!=0)
            {
                triangles.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                index = listBox1.SelectedIndex;
                N_set--;
                Active = false;
            }
        }
    
        private void glControl1_MouseMove(object sender, MouseEventArgs e)//перемещение набора фигур мышью
        {
            x_offset = e.X - dx;
            y_offset = e.Y - dy;
            dx = e.X;
            dy = e.Y;
            if (e.Button == MouseButtons.Left && (!Paint_or_Move) )
            {
                var ind = listBox1.SelectedIndices;
                index = listBox1.SelectedIndex;
                if (ind.Count != 0 && Active)
                {
                    foreach (Triangles tr in triangles[index])
                    {
                        tr.a.x += x_offset;
                        tr.a.y -= y_offset;
                        tr.b.x += x_offset;
                        tr.b.y -= y_offset;
                        tr.c.x += x_offset;
                        tr.c.y -= y_offset;
                    }
                }
            }
        }    

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if(triangles[N_set].Count!=0)
                    triangles[N_set].RemoveAt(triangles[N_set].Count-1);              
    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ind = listBox1.SelectedIndices;
            if(ind.Count != 0)
            {
                index = listBox1.SelectedIndex;
                Active = true;
            }                          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Active = false;
            index = listBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Smooth = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (triangles[N_set].Count != 0)
                triangles[N_set].RemoveAt(triangles[N_set].Count - 1);  
        }
    }
}
