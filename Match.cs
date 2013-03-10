using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class Match
    {
        protected Team HostTeam;
        protected Team GuestTeam;
        protected string StartDate;
        protected string EndDate;
        protected List<Refree> Refrees;
        protected Place Stadium;
        protected HostOrganization HostOrganizationName;
        protected League LeagueName;
        public Match()
        {
        }
        public Match(Team HT, Team GT,string sDate,string eDate,List<Refree> R,Place S,HostOrganization HO,League L)
        {
            HostTeam = HT;
            GuestTeam = GT;
            StartDate = sDate;
            EndDate = eDate;
            Refrees = R;
            Stadium = S;
            HostOrganizationName = HO;
            LeagueName = L;
        }

    }
}
