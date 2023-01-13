using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab4
{
    public partial class FormNewDialog : Form
    {
        public FormNewDialog()
        {
            InitializeComponent();
        }

        private Size newSize;

        /// <summary>
        /// This dialog box will pop up when the user clicks the "New" tab. The user
        /// is prompted to select a size. When the user then clicks "OK", it will open
        /// a new form with that size.
        /// </summary>
        public Size SizeOfNewDialogBox
        {
            get
            {
                
                if (radioButton_small.Checked)
                {
                    newSize = new Size(640, 480);
                } else if (radioButton_med.Checked)
                {
                    newSize = new Size(800, 600);
                } else if (radioButton_large.Checked)
                {
                    newSize = new Size(1024, 768);
                }

                return newSize;
            }
        }

    }

}
