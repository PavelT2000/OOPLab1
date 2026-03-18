using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlot
{
    internal class TransportShip : SpaceVessel
    {
        public int Capacity { get; set; }
        public TransportShip(string model, int cap) : base(model, 100) { Capacity = cap; }

        public override void ExecuteMission() => Fuel -= 10;
    }
}
