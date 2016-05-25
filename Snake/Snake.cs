using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

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

        internal void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
