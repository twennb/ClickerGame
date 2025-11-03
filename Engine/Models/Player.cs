using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private int _currentPoints;

        public int CurrentPoints
        {
            get { return _currentPoints; }
            set
            {
                _currentPoints = value;
                OnPropertyChanged(nameof(CurrentPoints));
            }
        }
    }
}
