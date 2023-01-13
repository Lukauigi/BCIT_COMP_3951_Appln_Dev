using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace COMP3951_Lab4
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        // Child form's fields
        private Image myImage;
        private Bitmap bm;

        /// <summary>
        /// A ReadOnly property to get the TextBox field's value.
        /// </summary>
        public PictureBox picturebox
        {
            get { return picture_url; }
        }

        /// <summary>
        /// Property to get/set the Image field's value.
        /// </summary>
        public Image Image
        {
            set
            {
                myImage = value;
                AutoScrollMinSize = myImage.Size;
            }
            get
            {
                if (myImage == null)
                {
                    myImage = new Bitmap(1, 1);
                }
                return myImage;
            }
        }

        /// <summary>
        /// Property to get/set the Bitmap field's value.
        /// </summary>
        public Bitmap bitmap
        {
            set
            {
                bm = value;
                AutoScrollMinSize = bm.Size;
            }
            get
            {
                return bm;
            }
        }

        /// <summary>
        /// Method to paint the form in a solid blue color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChild_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics gr = e.Graphics;
                gr.Clear(Color.Blue);
                //Image img = myImage;
                //Rectangle rect = new Rectangle(0, 0, this.Image.Width, this.Image.Height);
                //gr.DrawImage(this.Image, 0, 0, new Rectangle(0, 0, this.Image.Width, this.Image.Height));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
