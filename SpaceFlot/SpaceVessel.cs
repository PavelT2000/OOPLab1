using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlot
{
    internal abstract class SpaceVessel
    {

        private string _uid;
        private double _fuel;

        public string ModelName { get; protected set; }

        public double Fuel
        {
            get => _fuel;
            set
            {
                if (value < 0) throw new ArgumentException("Топливо не может быть отрицательным!");
                _fuel = value;
            }
        }

        protected SpaceVessel(string model, double initialFuel)
        {
            _uid = Guid.NewGuid().ToString().Substring(0, 5);
            ModelName = model;
            Fuel = initialFuel;
        }

        ~SpaceVessel() => Console.WriteLine($"Объект {ModelName} удален из памяти");


        public virtual string GetStatus() => $"[{_uid}] Корабль {ModelName}: Топливо {Fuel}%";

        public abstract void ExecuteMission();
    }
}
