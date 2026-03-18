using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlot
{
    internal class CombatShip : SpaceVessel
    {
        public int FirePower { get; set; }
        public CombatShip(string model, int power) : base(model, 100) { FirePower = power; }

        public override void ExecuteMission() => Fuel -= 20; 
        public override string GetStatus() => base.GetStatus() + $" | Мощь: {FirePower}";
    }
}
