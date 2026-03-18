using System.Windows.Forms;

namespace SpaceFlot
{
    public partial class Form1 : Form
    {
        private List<SpaceVessel> _fleet = new List<SpaceVessel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddShip.Enabled = true;
            pnlInputContainer.Controls.Clear(); // Убираем старое "окошко"

            UserControl selectedControl = comboBox1.SelectedIndex switch
            {
                0 => new CombatInputControl(),
                1 => new TransportInputControl(), // Если выбрали "Транспортный"
                _ => throw new Exception("Неизвестный тип корабля")
            };

            selectedControl.Dock = DockStyle.Fill;
            pnlInputContainer.Controls.Add(selectedControl);
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            try
            {

                // Ищем контрол в нашей панели
                if (pnlInputContainer.Controls.Count > 0)
                {
                    var currentControl = pnlInputContainer.Controls[0];
                    SpaceVessel newShip = null;
                    switch (currentControl)
                    {
                        case CombatInputControl combatUI:
                            // Если это боевой контрол, создаем Эсминец
                            newShip = new Destroyer(combatUI.ShipName);
                            ((Destroyer)newShip).FirePower = combatUI.FirePower;
                            break;

                        case TransportInputControl transUI:
                            // Если это транспортный контрол, создаем Грузовик
                            newShip = new CargoFreighter(transUI.ShipName);
                            ((CargoFreighter)newShip).Capacity = transUI.Capacity;
                            break;

                        default:
                            // Fail-Fast: если попал неизвестный контрол
                            throw new InvalidOperationException("Выбран неизвестный тип интерфейса ввода!");
                    }
                    _fleet.Add(newShip);
                    UpdateUI();

                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки ввода
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateUI()
        {
            lstShips.Items.Clear();
            foreach (var ship in _fleet)
            {
                lstShips.Items.Add(ship.GetStatus());
            }
        }

        private void btnAddDestroyer_Click(object sender, EventArgs e)
        {
            _fleet.Add(new Destroyer("Destroyer"));
            UpdateUI();
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            _fleet.Add(new CargoFreighter("Cargo"));
            UpdateUI();
        }

        private void lstShips_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstShips.SelectedIndex;
            _fleet[selectedIndex].ExecuteMission();
            UpdateUI();
            lstShips.SetSelected(selectedIndex,true);


        }
    }
}
