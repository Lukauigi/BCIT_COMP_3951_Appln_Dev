using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            groupBoxColor.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            groupBoxColor.Visible = true;
        }

        private void radioButtonNoColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton myRadioButton = sender as RadioButton;
            if (myRadioButton.Checked)
            {
                pictureBoxColor.BackColor = Color.Transparent;
            }
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton myRadioButton = sender as RadioButton;
            if (myRadioButton.Checked)
            {
                pictureBoxColor.BackColor = Color.Red;
            }
        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton myRadioButton = sender as RadioButton;
            if (myRadioButton.Checked)
            {
                pictureBoxColor.BackColor = Color.Yellow;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton myRadioButton = sender as RadioButton;
            if (myRadioButton.Checked)
            {
                pictureBoxColor.BackColor = Color.Blue;
            }
        }
    }
}
