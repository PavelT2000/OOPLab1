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
    public partial class CombatInputControl : UserControl
    {
        public string ShipName => txtModelName.Text;

        public int FirePower
        {
            get
            {
                if (!int.TryParse(txtFirePower.Text, out int result))
                    throw new FormatException("Огневая мощь должна быть целым числом!");
                return result;
            }
        }

        public CombatInputControl() { InitializeComponent(); }
    }
}
