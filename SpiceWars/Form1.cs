using System;
using System.Windows.Forms;

namespace SpiceWars
{
    public partial class SpiceWarsWindow : Form
    {
        int[] playerStock = new int[5];

        Harbor[] destination = Manager.FillPorts();

        int currentLocation = 0;

        public SpiceWarsWindow()
        {
            InitializeComponent();
            UpdateGUI();
            currentLabel.Text = destination[currentLocation].Name;
        }

        // SailBtn Clickevent, set the new destination from DESTINATIONBOX_INDEX
        private void SailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentLabel.Text != destinationBox.SelectedItem.ToString())
                {
                    currentLabel.Text = destinationBox.SelectedItem.ToString();
                    Manager.GetProductPriceValue(destination[currentLocation].goods);
                    currentLocation = destinationBox.SelectedIndex;
                    Config.Default.playerMoney -= 2;
                    UpdateGUI();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                valueBox.Clear();
                statusBox.Items.Add("Nicht genügend Geld zum Segeln vorhanden!");
            }
           
        }

        // BuyBtn Clickevent, Adds and Substract the Value from the stocks
        private void BuyBtn_Click(object sender, EventArgs e)
        {
            // Abprüfen ob genügend vorhanden
            try
            {
                if (destination[currentLocation].stock[goodiesBox.SelectedIndex] >= int.Parse(valueBox.Text) &&
                    (int.Parse(valueBox.Text) * destination[goodiesBox.SelectedIndex].goods[goodiesBox.SelectedIndex].Price <= Config.Default.playerMoney))
                {
                    Config.Default.playerMoney -= (int.Parse(valueBox.Text) * destination[goodiesBox.SelectedIndex].goods[goodiesBox.SelectedIndex].Price);
                    playerStock[goodiesBox.SelectedIndex] += int.Parse(valueBox.Text);
                    destination[currentLocation].stock[goodiesBox.SelectedIndex] -= int.Parse(valueBox.Text);
                    UpdateGUI();
                }
                else
                {
                    valueBox.Clear();
                    statusBox.Items.Add("Nicht genügend Stoff vorhanden!");
                }
            }
            catch (Exception)
            {
                valueBox.Clear();
                statusBox.Items.Add("Bitte nur Zahlen angeben!");
            }
        }

        // SellBtn Clickevent, Adds and Substract the Value from the stocks
        private void SellBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerStock[stockBox.SelectedIndex] >= int.Parse(valueBox.Text))
                {
                    Config.Default.playerMoney += (int.Parse(valueBox.Text) * destination[stockBox.SelectedIndex].goods[stockBox.SelectedIndex].Price);
                    playerStock[stockBox.SelectedIndex] -= int.Parse(valueBox.Text);
                    destination[currentLocation].stock[stockBox.SelectedIndex] += int.Parse(valueBox.Text);
                    UpdateGUI();
                }
                else
                {
                    valueBox.Clear();
                    statusBox.Items.Add("Nicht genügend Stoff an Bord!");
                }

            }
            catch (Exception)
            {
                valueBox.Clear();
                statusBox.Items.Add("Bitte nur Zahlen angeben!");
            }
        }

        // Updates all TEXTBOXES and the VALUEBOX and the MONEY string
        private void UpdateGUI()
        {
            this.
            valueBox.Clear();
            statusBox.Items.Clear();
            stockBox.Items.Clear();
            goodiesBox.Items.Clear();
            destinationBox.Items.Clear();
            for (int i = 0; i < destination.Length; i++)
            {
                stockBox.Items.Add(playerStock[i] + " - " + destination[currentLocation].goods[i].Name);
                goodiesBox.Items.Add($"{destination[currentLocation].stock[i]} -{destination[currentLocation].goods[i].Price} - {destination[i].goods[i].Name}");
                destination[i].stock[i].ToString();
                destinationBox.Items.Add(destination[i].Name);
            }
            moneyLabel.Text = "Goldbestand: " + Config.Default.playerMoney.ToString();
        }
    }
}