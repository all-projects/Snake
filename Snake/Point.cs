using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()                                      //default constructor
        {            
        }

        public Point( int _x, int _y, char _sym)            // constructor with members
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)                               //constructor to add point by other point
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }        

        public void Move(int offset, Direction direction)   //create snake of given lenght and direction
        {
            if(direction == Direction.Right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
            else if (direction == Direction.Up )
            {
                y = y - offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()                             //to clear point on the screen during move
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()               //for debuggin
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
