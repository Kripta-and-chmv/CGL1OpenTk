

namespace CmpGrfLAB1
{
    class Triangles
    {
        public points a { get; set; }
        public points b { get; set; }
        public points c { get; set; }
       //Point's color
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }

        public Triangles(points _a, points _b, points _c, int _red, int _green, int _blue )
        {
            a = _a;
            b = _b;
            c = _c;
            red = _red;
            green = _green;
            blue = _blue;
        }
    }
}
