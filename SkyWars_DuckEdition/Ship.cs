using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyWars_DuckEdition
{
    public abstract class Ship : Command
    {

        public string shipType { get; set; }
        public int movetemp = 0;
        Random rng = new Random();

        public string location { get; set; }
        public Command cmd = new Command();
        //Dictionary used to store previous moves and be undone if needed
        public Dictionary<int, string> previousMove = new Dictionary<int, string>();

        public void movement()
        {
            //Command pattern used for movement
            location = cmd.move(rng);
            movetemp = movetemp + 1;
            previousMove.Add(movetemp, location);
        }

        public void undoMove()
        {
            //Command called for undo movement
            if (movetemp != 0)
            {
                movetemp = movetemp - 1;
                location = cmd.undoMove(movetemp, previousMove);
            }
        }
    }
}
