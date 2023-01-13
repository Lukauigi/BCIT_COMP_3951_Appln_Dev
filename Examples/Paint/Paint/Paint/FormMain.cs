using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Simple paint application
/// </summary>
namespace Paint
{
    public partial class FormMain : Form
    {
        bool isPainting = false;
        Color penColor = Color.Blue;
        int penWidth = 6;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(penColor), e.X, e.Y, penWidth, penWidth);
                graphics.Dispose();
                
                
            }
        }

        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            try
            {
                if (!File.Exists("c:\\_Scrum_Meeting.JPG"))
                    throw new FileNotFoundException();
                else
                {
                    Image myImage = Image.FromFile("c:\\_Scrum_Meeting.JPG");
                    graphics.DrawImage(myImage, 0, 0, this.Size.Width, this.Size.Height);
                }
                
            }
            catch (FileNotFoundException ex)
            {
               MessageBox.Show($"The image file was not found: '{ex}'");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
                return;

            }
            finally 
            {
                graphics.Dispose();
            }
            
            
        }

        private void colorPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogPen.ShowDialog();
            penColor = colorDialogPen.Color;
 
        }
    }
}
