using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private float _currentPoints;
        private int _numberOfAutoClickers;

        public float CurrentPoints
        {
            get { return _currentPoints; }
            set
            {
                _currentPoints = value;
                OnPropertyChanged(nameof(CurrentPoints));
            }
        }
        public int NumberOfAutoClickers
        {
            get { return _numberOfAutoClickers; }
            set
            {
                _numberOfAutoClickers = value;
                OnPropertyChanged(nameof(NumberOfAutoClickers));
            }
        }
    }
}
