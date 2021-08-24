using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiceWars
{
    public partial class SpiceWarsWindow : Form
    {
        int[] playerStock = new int[5];

        string[] goods = new string[] { "Product A", "Product B", "Product C", "Product D", "Product E" };
        Harbor[] destinations = new Harbor[5];

        int money = 100;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public SpiceWarsWindow()
        {
            InitializeComponent();
            destinations = InitGame();

            for (int i = 0; i < goods.Length; i++)
            {
                goodiesBox.Items.Add(destinations[i].stock[i] + " - " + goods[i]);
                stockBox.Items.Add(playerStock[i] + " - " + goods[i]);
                destinationBox.Items.Add(destinations[i].Name);
            }
            currentLabel.Text = destinations[0].Name;
            moneyLabel.Text = "Goldbestand: " + money.ToString();
        }

        

        private void goodiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SailBtn_Click(object sender, EventArgs e)
        {
            if (currentLabel.Text != destinationBox.SelectedItem.ToString())
            {
                currentLabel.Text = destinationBox.SelectedItem.ToString();
            }
            else
            {

            }

        }

        private Harbor[] InitGame()
        {
            Harbor[] harbors = new Harbor[] { new Harbor("Köln"), new Harbor("Leverkusen"), new Harbor("Kerpen"), new Harbor("Brühl"), new Harbor("Frankfurt") };

            return harbors;
        }
    }
}
