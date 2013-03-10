using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class ObjectProperties
    {
        protected string ObjectPrimaryID{get; set;}
        protected int ObjectSecondaryID { get; set; }
        protected string ObjectName { get; set; }   
        public ObjectProperties() 
            {
                
            }
        public string Equals()
            {
                return "objectProperties";
            }
        public string Hash()
            {
                return "Hashed output";
            }

    }
}
