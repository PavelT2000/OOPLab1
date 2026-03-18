using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFlot
{
    public partial class TransportInputControl : UserControl
    {
        public string ShipName => txtModelName.Text;

        public int Capacity
        {
            get
            {
                if (!int.TryParse(txtCapacity.Text, out int result))
                    throw new ArgumentException("Грузоподъемность заполнена неверно!");
                return result;
            }
        }

        public TransportInputControl() { InitializeComponent(); }
    }
}
