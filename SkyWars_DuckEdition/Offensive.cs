using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public class Offensive : mode
    {
        public mode mode
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        //Implement interface as part of strategy pattern
        public string shipMode()
        {
            return "Offensive";
        }
    }
}
