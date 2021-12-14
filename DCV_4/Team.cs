using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DCV_4
{
    public class Team : INotifyPropertyChanged
    {
        private readonly string _name;
        private int _goalsScored = 0;
        private int _goalsConceded = 0;

        public Team(string name)
        {
            _name = name;
        }

        [DisplayName("Name")]
        public string Name { get { return _name; } }

        [DisplayName("Goals Scored")]
        public int GoalsScored
        {
            get { return _goalsScored; }

            set
            {
                if (value != _goalsScored)
                {
                    _goalsScored = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [DisplayName("Goals Conceded")]
        public int GoalsConceded
        {
            get { return _goalsConceded; }

            set
            {
                if (value != _goalsConceded)
                {
                    _goalsConceded = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
