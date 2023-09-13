using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado.Models
{
    public class Bomb : Coordinates
    {
        public Bomb(int x, int y) { 
            this.y = y;
            this.x = x; 
        }
    }
}
