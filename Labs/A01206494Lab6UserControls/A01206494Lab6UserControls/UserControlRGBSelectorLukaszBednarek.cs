using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 6, Create .dll for other apps to load in this rgb colour selector.
/// Author: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace A01206494Lab6UserControls
{
    /// <summary>
    /// Display an adaptive rgb colour selector.
    /// </summary>
    public partial class UserControlRGBSelectorLukaszBednarek: UserControl
    {
        /// <summary>
        /// Contructs the control.
        /// </summary>
        public UserControlRGBSelectorLukaszBednarek()
        {
            InitializeComponent();
            ApplyColourToPanel();
        }

        /// <summary>
        /// Applies colours from red, green, and blue trackers to the colour panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyColourToPanel(object sender, EventArgs e)
        {
            int redTrackValue = redTrackBar.Value;
            int greenTrackValue = greenTrackBar.Value;
            int blueTrackValue = blueTrackBar.Value;

            ColourPanel.BackColor = Color.FromArgb(redTrackValue, greenTrackValue, blueTrackValue);
        }

        /// <summary>
        /// Applies colours from red, green, and blue trackers to the colour panel.
        /// 
        /// Overloaded version for start of application.
        /// </summary>
        private void ApplyColourToPanel()
        {
            int redTrackValue = redTrackBar.Value;
            int greenTrackValue = greenTrackBar.Value;
            int blueTrackValue = blueTrackBar.Value;

            ColourPanel.BackColor = Color.FromArgb(redTrackValue, greenTrackValue, blueTrackValue);
        }
    }
}
