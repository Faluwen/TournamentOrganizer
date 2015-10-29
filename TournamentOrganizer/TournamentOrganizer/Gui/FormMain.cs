using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOrganizer.Gui
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            tabControlRibbon.TabPages.Remove(tabPageAdmin);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlRibbon.TabPages.Remove(tabPageStartseite);
            tabControlRibbon.TabPages.Add(tabPageAdmin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlRibbon.TabPages.Remove(tabPageAdmin);
            tabControlRibbon.TabPages.Add(tabPageStartseite);
        }
    }
}
