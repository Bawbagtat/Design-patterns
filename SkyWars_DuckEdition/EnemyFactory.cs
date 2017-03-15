using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public class EnemyFactory
    {
        //Enemy type is created here
        public EnemyShipType setShipType(int num)
        {
            EnemyShipType est = null;
            if(num ==0)
            {
                est = new battleStar();
            }
            else if(num == 1)
            {
                est = new battleShooter();
            }
            else if(num == 2)
            {
                est = new battleCruiser();
            }
            else
            {
                est = new battleStar();
            }
            //returns enemy type
            return est;
        }
       
    }
}
