using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityModule.Data.Enumerations;

namespace EventModule.Gui
{
    public partial class ControlCreateSwiss : UserControl
    {
        public ControlCreateSwiss()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            checkBoxFinalists.Checked = true;

            comboBoxBO.Items.Add(MatchFormate.Bo1);
            comboBoxBO.Items.Add(MatchFormate.Bo3);
            comboBoxBO.Items.Add(MatchFormate.Bo5);
            comboBoxBO.Items.Add(MatchFormate.Bo7);
            comboBoxBO.Items.Add(MatchFormate.Bo9);
            comboBoxBO.Items.Add(MatchFormate.Bo11);
            comboBoxBO.SelectedItem = MatchFormate.Bo5;

            comboBoxFormat.Items.Add(TurnierFormate.Conquest);
            comboBoxFormat.Items.Add(TurnierFormate.LastHeroStanding);
            comboBoxFormat.SelectedItem = TurnierFormate.Conquest;
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem != null)
            {
                listBoxPlayers.Items.Remove(listBoxPlayers.SelectedItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNewPlayer.Text))
            {
                listBoxPlayers.Items.Add(textBoxNewPlayer.Text);
            }
        }
    }
}
