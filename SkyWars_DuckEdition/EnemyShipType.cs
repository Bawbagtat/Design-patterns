using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public abstract class EnemyShipType
    {
        public EnemyFactory EnemyFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        //Ship type is taken from the Enemy Factory
        public abstract string getEnemyType();
    }
}
