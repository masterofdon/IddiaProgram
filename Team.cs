using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class Team : Entity
    {
        protected string TeamNationality;
        protected string TeamSportField;
        protected Person TeamCoach;
        protected List<Player> TeamPlayers;


        public Team()
        {
        }
        public Team(string TN, string TSF, Person TC, List<Player> TP)
        {
            TeamNationality = TN;
            TeamSportField = TSF;
            TeamCoach = TC;
            TeamPlayers = TP;
        }
        public double GetTotalMarketValue()
            {
                return 0.0;
            }
        public double GetMarketValueOfList(List<Player> p)
            {
                return 0.0;
            }

    }
}
