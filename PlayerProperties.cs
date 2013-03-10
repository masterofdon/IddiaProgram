using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class PlayerProperties : ObjectProperties
    {
        protected string PlayerName;
        protected string PlayerLastname;
        protected string PlayerNationality;
        protected int PlayerAge;
        protected string PlayerPosition;
        protected string PlayerStatus;
        protected double PlayerSalary;
        protected double PlayerMarketValue;

        public PlayerProperties(string n,string pId,int sId)
            {
                this.ObjectName = n;
                this.ObjectPrimaryID = pId;
                this.ObjectSecondaryID = sId;
            }
        public bool Equals(PlayerProperties e)
            {
                return false;
            }
        public string Hash(PlayerProperties e)
            {
                return "hashed output";
            }

    }
}
