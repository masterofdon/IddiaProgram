using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class MatchProperties : ObjectProperties
    {
        protected string StartDate;
        protected string EndDate;
        protected List<Refree> Refrees;
        protected Place Stadium;
        protected HostOrganization HostOrganizationName;
        protected League LeagueName;
    }
}
