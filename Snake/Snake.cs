using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;                               // or public, or internal if accessed from Program.cs

        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();

            for (int i= 0; i < length; i ++)
            {
                direction = _direction;
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void MoveSnake()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextpoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextpoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }
        
        internal bool Eat(Point food)
        {
            Point head = GetNextpoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }       

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
