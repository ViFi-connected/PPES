using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DCV_4
{
    public class Match : INotifyPropertyChanged
    {
        private readonly int _round;
        private readonly string _homeTeam;
        private readonly string _guestTeam;
        private int _homeTeamGoals = 0;
        private int _guestTeamGoals = 0;

        public Match(int round, string homeTeam, string guestTeam)
        {
            _round = round;
            _homeTeam = homeTeam;
            _guestTeam = guestTeam;
        }

        [DisplayName("Round")]
        public int Round { get { return _round; } }

        [DisplayName("Home Team")]
        public string HomeTeam { get { return _homeTeam; } }

        [DisplayName("Guest Team")]
        public string GuestTeam { get { return _guestTeam; } }

        [DisplayName("Home Team Goals")]
        public int HomeTeamGoals {

            get { return _homeTeamGoals; } 
            
            set 
            {
                if (value != _homeTeamGoals)
                {
                    _homeTeamGoals = value;
                    NotifyPropertyChanged();
                }
            }
        }

        [DisplayName("Guest Team Goals")]
        public int GuestTeamGoals
        {
            get { return _guestTeamGoals; }

            set
            {
                if (value != _guestTeamGoals)
                {
                    _guestTeamGoals = value;
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
