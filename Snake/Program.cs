using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(90, 30);

            //draw square
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+'); 
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 0, '+');
            rightLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 24, 78, '+');
            leftLine.Draw();



            Console.ReadLine();
        }        
    }
}
