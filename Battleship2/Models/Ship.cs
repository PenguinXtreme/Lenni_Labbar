using Battleship2.Enum;
using Battleship2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2.Models
{
    internal class Ship : BaseViewModel
    {
        public Ship(int size)
        {
            Size = size;
        }
        /// <summary>
        /// Number of squares for ship
        /// </summary>
        public int Size { get; }
        /// <summary>
        /// Set of Coordinates occupied by the ship
        /// </summary>
        public ObservableCollection<Point> Coordinates { get; private set; } = new ObservableCollection<Point>();
        /// <summary>
        /// Ship direction
        /// </summary>
        public Direction Direction { get; private set; } = Direction.Vertical;

        public void SetCoordinates(Point startPoint)
        {
            int x = startPoint.X;
            int y = startPoint.Y;
            switch (Direction)
            {
                case Direction.Horizontal:
                    for (int i = 0; i < Size; i++)
                    {
                        

                        Point point = new Point(x, y);
                        Coordinates.Add(point);
                        x++;

                    }
                    break;
                case Direction.Vertical:
                    for (int i = 0; i < Size; i++)
                    {
                        
                        Point point = new Point(x, y);
                        Coordinates.Add(point);
                        y++;

                    }
                    break;
                
            }

            


        }
    }
}
