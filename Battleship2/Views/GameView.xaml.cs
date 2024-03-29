﻿
using Battleship2.Views.Boats;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battleship2.Views
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
        }
         


        private void Ocean_DragOver(object sender, DragEventArgs e)
        {

             

           object data = e.Data.GetData(DataFormats.Serializable);

            if (data is Ship boat )
            {
                Point currentPosition = e.GetPosition(ocean);
                Point calculatedPosition = GetCalculatedPosition(currentPosition);
                Canvas.SetLeft(boat, calculatedPosition.X);
                Canvas.SetTop(boat, calculatedPosition.Y);
                if (!ocean.Children.Contains(boat))
                {
                    Harbour.Children.Remove(boat);
                    ocean.Children.Add(boat);

                }



            }

           
        }

        private Point GetCalculatedPosition(Point currentPosition)
        {
            int cellSize = 50;
            double x = currentPosition.X; 
            double y = currentPosition.Y;

            x = Math.Floor(x/cellSize) * cellSize;
            y = Math.Floor(y/cellSize) * cellSize;
            return new Point(x, y);
        }

        private void Ocean_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is Ship boat)
            {
                double left = Canvas.GetLeft(boat);
                double top = Canvas.GetTop(boat);

                boat.StartPoint = GetConvertedDropPoint(left, top);

            }





        }

        private Point GetConvertedDropPoint(double left, double top)
        {
            double x = left / 50;
            double y = top / 50;
            return new Point(x, y);
        }
    }
}
