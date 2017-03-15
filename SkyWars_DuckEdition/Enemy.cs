using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public class Enemy : Ship
    {
        public string enemyChoice { get; set; }
        public void setEnemy()
        {
            //Command for command pattern
            Random rng = new Random();
            int number = rng.Next(0, 3);

            EnemyFactory factory = new EnemyFactory();
            EnemyShipType shipType = factory.setShipType(number);
            enemyChoice = shipType.getEnemyType();
        }

        public void spawn()
        {
            //Spawn location for Enemy
            location = "0,0";

        }
    }
}
