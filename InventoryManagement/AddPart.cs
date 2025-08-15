using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            InHouseButton.Checked = true;
            InHousePanel.Visible = true;
            OutsourcedPanel.Visible = false;
        }

        private void InHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseButton.Checked)
            {
                OutsourcedButton.Checked = false;
                OutsourcedPanel.Visible = false;
                InHousePanel.Visible = true;
            }
        }

        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedButton.Checked)
            {
                InHouseButton.Checked = false;
                InHousePanel.Visible = false;
                OutsourcedPanel.Visible = true;
            }
        }
    }
}
