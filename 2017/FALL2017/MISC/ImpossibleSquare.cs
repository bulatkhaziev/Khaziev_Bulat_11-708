using System;
using System.Diagnostics;
using System.Drawing;

namespace RefactorMe
{
    class Risovatel
    {
        static Bitmap image = new Bitmap(800, 600);
        static float x, y;
        static Graphics graphics;
        
        public static void Initialize()
        {
            graphics = Graphics.FromImage(image);
        }

        public static void set_pos(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void Go(double L, double angle)
        {
            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + L * Math.Cos(angle));
            var y1 = (float)(y + L * Math.Sin(angle));
            graphics.DrawLine(Pens.Yellow, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
        
        public static void DrawSquare(int x, int y, int index)
        {
            Risovatel.set_pos(x, y);
            Risovatel.Go(100, Math.PI * index / 2);
            Risovatel.Go(10 * Math.Sqrt(2), Math.PI / 4 + (Math.PI * index / 2));
            Risovatel.Go(100, ((Math.PI * index) / 2) + Math.PI);
            Risovatel.Go(100 - (double)10, Math.PI / 2 + (Math.PI * index / 2) % (2 * Math.PI));
        }
    }

    public class StrangeThing
    {
        public static void Main()
        {
            Risovatel.Initialize();

            Risovatel.DrawSquare(10, 0, 0);
            Risovatel.DrawSquare(120, 10, 1);
            Risovatel.DrawSquare(110, 120, 2);
            Risovatel.DrawSquare(0, 110, 3);

            Risovatel.ShowResult();
        }
    }
}