using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A01206494Lab6UserControls;

/// <summary>
/// Lab 6, Create .dll for other apps to load in this form tester.
/// Author: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace Lab6LibraryExecutor
{
    /// <summary>
    /// Form to test custom controls.
    /// </summary>
    public partial class Tester : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Tester()
        {
            InitializeComponent();

            void ChangeText(object sender, EventArgs e)
            {
                eventButton.Text = "Please work";
            }

            eventButton.LukaszEvent += new LukaszButton.CustomButtonEventHandle(ChangeText);
        }
        
    }
}
