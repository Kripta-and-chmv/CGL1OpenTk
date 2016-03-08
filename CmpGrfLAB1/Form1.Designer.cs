namespace CmpGrfLAB1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glControl1 = new OpenTK.GLControl();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnDeleteSet = new System.Windows.Forms.Button();
            this.lstbxSets = new System.Windows.Forms.ListBox();
            this.Mode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkbxSmooth = new System.Windows.Forms.CheckBox();
            this.btnDelLastTriangle = new System.Windows.Forms.Button();
            this.btnDelPoints = new System.Windows.Forms.Button();
            this.lstbxTriangles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glControl1.BackColor = System.Drawing.Color.White;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.glControl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(852, 507);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseClick);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(873, 40);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(116, 35);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.color_Click);
            // 
            // btnDeleteSet
            // 
            this.btnDeleteSet.Location = new System.Drawing.Point(873, 317);
            this.btnDeleteSet.Name = "btnDeleteSet";
            this.btnDeleteSet.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSet.TabIndex = 2;
            this.btnDeleteSet.Text = "Delete";
            this.btnDeleteSet.UseVisualStyleBackColor = true;
            this.btnDeleteSet.Click += new System.EventHandler(this.Del_Click);
            // 
            // lstbxSets
            // 
            this.lstbxSets.FormattingEnabled = true;
            this.lstbxSets.Location = new System.Drawing.Point(873, 110);
            this.lstbxSets.Name = "lstbxSets";
            this.lstbxSets.Size = new System.Drawing.Size(120, 82);
            this.lstbxSets.TabIndex = 3;
            this.lstbxSets.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(314, 8);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(116, 13);
            this.Mode.TabIndex = 4;
            this.Mode.Text = "selected drawing mode";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set color:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "List set:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Remove set:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(954, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkbxSmooth
            // 
            this.chkbxSmooth.AutoSize = true;
            this.chkbxSmooth.Location = new System.Drawing.Point(873, 373);
            this.chkbxSmooth.Name = "chkbxSmooth";
            this.chkbxSmooth.Size = new System.Drawing.Size(62, 17);
            this.chkbxSmooth.TabIndex = 11;
            this.chkbxSmooth.Text = "Smooth";
            this.chkbxSmooth.UseVisualStyleBackColor = true;
            this.chkbxSmooth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDelLastTriangle
            // 
            this.btnDelLastTriangle.Location = new System.Drawing.Point(873, 421);
            this.btnDelLastTriangle.Name = "btnDelLastTriangle";
            this.btnDelLastTriangle.Size = new System.Drawing.Size(75, 50);
            this.btnDelLastTriangle.TabIndex = 12;
            this.btnDelLastTriangle.Text = "Delete the last entity";
            this.btnDelLastTriangle.UseVisualStyleBackColor = true;
            this.btnDelLastTriangle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelPoints
            // 
            this.btnDelPoints.Location = new System.Drawing.Point(954, 421);
            this.btnDelPoints.Name = "btnDelPoints";
            this.btnDelPoints.Size = new System.Drawing.Size(75, 50);
            this.btnDelPoints.TabIndex = 13;
            this.btnDelPoints.Text = "Delete the last points";
            this.btnDelPoints.UseVisualStyleBackColor = true;
            this.btnDelPoints.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstbxTriangles
            // 
            this.lstbxTriangles.FormattingEnabled = true;
            this.lstbxTriangles.Location = new System.Drawing.Point(873, 198);
            this.lstbxTriangles.Name = "lstbxTriangles";
            this.lstbxTriangles.Size = new System.Drawing.Size(120, 82);
            this.lstbxTriangles.TabIndex = 3;
            this.lstbxTriangles.SelectedIndexChanged += new System.EventHandler(this.lstbxTriangles_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 507);
            this.Controls.Add(this.btnDelPoints);
            this.Controls.Add(this.btnDelLastTriangle);
            this.Controls.Add(this.chkbxSmooth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.lstbxTriangles);
            this.Controls.Add(this.lstbxSets);
            this.Controls.Add(this.btnDeleteSet);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDeleteSet;
        private System.Windows.Forms.ListBox lstbxSets;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkbxSmooth;
        private System.Windows.Forms.Button btnDelLastTriangle;
        private System.Windows.Forms.Button btnDelPoints;
        private System.Windows.Forms.ListBox lstbxTriangles;
    }
}

