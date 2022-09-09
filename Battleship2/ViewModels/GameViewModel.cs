using Battleship2.Models;
using Battleship2.ViewModels.Base;

using Battleship2.Views.Boats;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2.ViewModels
{
    internal class GameViewModel : BaseViewModel
    {
        public PlayerViewModel Player1 { get; set; } = new HumanPlayerViewModel();
        public PlayerViewModel Player2 { get; set; } = new HumanPlayerViewModel();

        public ObservableCollection<Boat>? Harbour { get; private set; }
        public GameViewModel()
        {
            Ship ship = new Ship(size: 3);
            ship.SetCoordinates(new System.Drawing.Point(0,9));
            FillHarbour();
            
        }

        private void FillHarbour()
        {
            Harbour = new ObservableCollection<Boat>()
            {
                new Cruiser(),
                new Battleship()
            };
        }
    }
}
