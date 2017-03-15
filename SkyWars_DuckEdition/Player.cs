using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public class Player : Ship
    {
        public string shipMode { get; set; }

        public void setMode(int num)
        {
            mode m = null;

            if(num ==0)
            {
                m = new Defensive();
            }
            else
            {
                m = new Offensive();
            }

            shipMode = m.shipMode();
        }    
    }
}
