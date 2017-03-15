using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public class Command
    {
        //Command pattern to call movement when needed
        public string move(Random rng)
        {
            int x = 0;
            int y = 0;
            
            x = rng.Next(0,3);
            y = rng.Next(0,3);
            string location = x + "," + y;
            return location;
        }

        public string undoMove(int move,Dictionary<int,string>previousMove)
        {
            foreach(KeyValuePair<int,string>tempMove in previousMove)
            {
                if(tempMove.Key==move)
                {
                    return tempMove.Value;
                }
            }
            return "0,0";
        }
    }
}
