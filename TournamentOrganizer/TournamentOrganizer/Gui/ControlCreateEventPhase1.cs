using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOrganizer.Gui
{
    public partial class ControlCreateEventPhase1 : UserControl
    { 
        public ControlCreateEventPhase1()
        {
            InitializeComponent();
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
