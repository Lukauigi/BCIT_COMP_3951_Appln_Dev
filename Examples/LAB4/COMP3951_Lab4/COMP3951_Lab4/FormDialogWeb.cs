using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab4
{
    public partial class FormDialogWeb : Form
    {
        public FormDialogWeb()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property to get/set the TextBox field.
        /// </summary>
        public TextBox TextBox
        {
            set { textbox_url = value; }
            get { return textbox_url; }
        }

        /// <summary>
        /// Property to get/set the TextBox field.
        /// </summary>
        public string UrlLink
        {
            get { return textbox_url.Text; }
        }

    }
}
