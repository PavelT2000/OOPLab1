using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlot
{
    internal sealed class Destroyer : CombatShip
    {
        public Destroyer(string name) : base(name, 500) { }
        public void LaunchNuke() => FirePower += 1000;
    }
}
