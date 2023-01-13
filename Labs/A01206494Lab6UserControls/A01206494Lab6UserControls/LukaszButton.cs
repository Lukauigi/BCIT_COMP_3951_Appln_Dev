using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 6, Create .dll for other apps to load in my custom button.
/// Author: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace A01206494Lab6UserControls
{
    /// <summary>
    /// A customized button named after its owner.
    /// </summary>
    public class LukaszButton : Button
    {
        private string _text;
        private Color _foregroundColor;
        private Color _backgroundColor;
        private int _foregroundTransparencey;
        private int _backgroundTransparencey;
        private HatchStyle _pattern;

        [Category("Lukasz Custom Design"),
        Description("Your name to be set on the button.")]
        public override string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        [Category("Lukasz Custom Design"),
        Description("Foreground color to be applied to the button.")]
        public Color ForegroundColor
        {
            get { return _foregroundColor; }
            set { _foregroundColor = value; this.Invalidate(); }
        }

        [Category("Lukasz Custom Design"),
        Description("Bakcground color to be applied to the button")]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; this.Invalidate(); }
        }

        [Category("Lukasz Custom Design"),
        Description("The transparencey value of the foreground color. An int between 0 and 255 (inclusive)")]
        public int ForegroundTransparencey
        {
            get { return _foregroundTransparencey; }
            set
            {
                if (value <= 255 && value >= 0)
                    _foregroundTransparencey = value;
                    this.Invalidate();
            }
        }

        [Category("Lukasz Custom Design"),
        Description("The transparencey value of the background color. An int between 0 and 255 (inclusive)")]
        public int BackgroundTransparencey
        {
            get { return _backgroundTransparencey; }
            set
            {
                if (value <= 255 && value >= 0)
                    _backgroundTransparencey = value;
                    this.Invalidate();
            }
        }

        [Category("Lukasz Custom Design"),
        Description("Set the pattern style of the button.")]
        public HatchStyle Pattern
        {
            get { return _pattern; }
            set { _pattern = value; this.Invalidate(); }
        }

        [Category("Lukasz Custom Design"),
        Description("Event to occur when button is clicked.")]
        public event LukaszButton.CustomButtonEventHandle LukaszEvent;

        /// <summary>
        /// Calls the event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnEvent(EventArgs e)
        {
            if (LukaszEvent != null)
            {
                LukaszEvent(this, e);
            }
            
        }

        /// <summary>
        /// Performs an event on a mouse's click
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.OnEvent((EventArgs)e);
            this.Invalidate();
        }

        public delegate void CustomButtonEventHandle(object sender, EventArgs e);

        /// <summary>
        /// Paints the control.
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            base.OnPaint(pevent);           
            try
            {
                HatchBrush hatchBrush = new HatchBrush(this.Pattern, Color.FromArgb(this.ForegroundTransparencey, this.ForegroundColor), Color.FromArgb(this.BackgroundTransparencey, this.BackgroundColor));
                pevent.Graphics.FillRectangle(hatchBrush, ClientRectangle);
                hatchBrush.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }  
        }
    }
}
