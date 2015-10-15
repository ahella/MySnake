using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // отрисовка рамочки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Drow();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Drow();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Drow();

            // отрисовка точек
            Point p1 = new Point(4, 5, '*');
            p1.Draw();

            Console.ReadLine();
        }

     /*   static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
    }
}
