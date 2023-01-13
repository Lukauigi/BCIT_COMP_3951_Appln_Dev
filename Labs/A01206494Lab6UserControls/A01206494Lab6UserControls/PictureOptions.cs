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
/// Lab 6, Create .dll for other apps to load in this custom control.
/// Author: Lukasz Bednarek
/// Date: March 2022
/// </summary>
namespace A01206494Lab6UserControls
{
    /// <summary>
    /// A whacky custom control!
    /// </summary>
    public partial class PictureOptions : UserControl
    {
        private int _horizontalStart;
        private int _verticalStart;

        /// <summary>
        /// Constructor.
        /// </summary>
        public PictureOptions()
        {
            InitializeComponent();
            Point startPoint = picture.Location;
            _horizontalStart = picture.Location.X;
            _verticalStart = picture.Location.Y;

            void Reset(object sender, EventArgs e)
            {
                picture.Location = startPoint;
                horizontalSlider.Value = 0;
                verticalSlider.Value = 0;
            }

            resetButton.LukaszEvent += new LukaszButton.CustomButtonEventHandle(Reset);
        }


        /// <summary>
        /// Inverts the color of the image. 
        /// 
        /// Credits: https://stackoverflow.com/questions/33024881/invert-image-faster-in-c-sharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invert(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(picture.Image); //bitmap of image
            for (int y = 0; (y <= (pic.Height - 1)); y++) //up to y pixels of image
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++) //up to x pixels of image
                {
                    Color inverse = pic.GetPixel(x, y); //get current set of pixels of pic
                    inverse = Color.FromArgb(255, (255 - inverse.R), (255 - inverse.G), (255 - inverse.B));//invert
                    pic.SetPixel(x, y, inverse); //set new inverted pic
                }
            }
            picture.Image = pic;
        }

        /// <summary>
        /// Moves the image location across horizontally.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveImageHorizontally(object sender, EventArgs e)
        {
            int horizontalPosition = horizontalSlider.Value + _horizontalStart;

            picture.Location = new Point(horizontalPosition, picture.Location.Y);
        }

        /// <summary>
        /// Moves the image location across vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveImageVetically(object sender, EventArgs e)
        {
            int verticalPosition = verticalSlider.Value + _verticalStart;

            picture.Location = new Point(picture.Location.X, verticalPosition);
        }
    }
}
