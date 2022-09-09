using Battleship2.Models;
using Battleship2.ViewModels.Base;
using Battleship2.Views.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Battleship2.ViewModels
{
    internal abstract class PlayerViewModel: BaseViewModel
    {


        public ObservableCollection<Ship> Ships { get; set; } = new ObservableCollection<Ship>();
        /// <summary>
        /// Players Battlefield
        /// </summary>
        public ObservableCollection<OceanPiece>? Ocean { get; private set; }

        private const int _battleFieldSize=10;

        public PlayerViewModel()
        {
            FillOcean();
        }

        private void FillOcean()
        {
            Ocean = new ObservableCollection<OceanPiece>(); 
            for (int X = 0; X < _battleFieldSize; X++)
            {
                for (int y = 0; y < _battleFieldSize; y++)
                {
                    var piece = new OceanPiece();
                    //piece.OceanColor = Brushes.Red;
                    Ocean.Add(piece);

                }
            }
        }
    }
}
