using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventModule.Gui
{
    public partial class ControlCreateEventPhase2 : UserControl
    {
        public ControlCreateEventPhase2()
        {
            InitializeComponent();
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
