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
using System.IO;


/// <summary>
/// Description: Lab 4 - Creating an MDI application.
/// Authors: John Ryue, Faiz Hassany
/// Both authors worked together by screen-sharing and coding together.
/// Date/Revisions: 
/// - Setting up MainForm and adding the controls, creating the child forms (FormChild and FormDialogWeb) (Feb 4, 2022)
/// - worked on implementing features for opening files on user's computer and from the web, and the Windows cascade, tile features (Feb 5, 2022)
/// - Revision #1: try to fix the open file from web feature (Feb 8, 2022)
/// - Revision #2: research and try to fix the save and saveAs features (Feb 9, 2022)
namespace COMP3951_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Generates a new form. According to the MDI.exe file we were given, opening a new file should 
        /// open a form that was filled in blue. 
        /// Source:
        /// - lecture notes for the Graphics.FromImage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFormGenerate_Click(object sender, EventArgs e)
        {
            FormNewDialog newForm = new FormNewDialog(); // creates form
            DialogResult re = newForm.ShowDialog();

            if (re == DialogResult.OK)
            {
                FormChild child = new FormChild();
                child.MdiParent = this;
                Graphics.FromImage(child.Image).FillRectangle((Brush)new SolidBrush(Color.Blue),
                    0, 0, child.Image.Width, child.Image.Height);
                child.Show();
                //child.Close();
                //child.Dispose();
            }
        }

        /// <summary>
        /// Open an image file from user's computer.
        /// Source: 
        /// - https://www.youtube.com/watch?v=7sOsZvrfkxE 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFromFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            DialogResult re = open.ShowDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (re == DialogResult.OK)
            {
                FormChild child = new FormChild();
                child.MdiParent = (Form)this;

                child.Image = Image.FromFile(open.FileName);
                child.bitmap = (Bitmap)child.Image;
                child.picturebox.Image = child.bitmap;
                child.Show();

                //child.Close();
                //child.Dispose();
                //child.Image.Dispose();
            }

        }

        /// <summary>
        /// This method allows the user to fill in a web URL that links to an image, and open in another form.
        /// Source:
        /// - https://www.codeproject.com/Questions/5294438/Load-a-image-from-URL-to-picture-box-using-csharp 
        /// - https://forgetcode.com/csharp/2052-download-images-from-a-url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFromWeb_Click(object sender, EventArgs e)
        {
            //creates a new dialog box for opening files from the web
            FormDialogWeb formweb = new FormDialogWeb();  
            formweb.ShowDialog();

            // if user clicks OK, continue
            if (formweb.ShowDialog() == DialogResult.OK)
                return;
            
            // create a new form that will open the picture from the web url
            FormChild child = new FormChild();
            child.MdiParent = this;
            string url_link = formweb.UrlLink;
            try
            {
                Stream streamResp = WebRequest.Create(url_link).GetResponse().GetResponseStream();
                child.Image = Image.FromStream(streamResp);
                streamResp.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open link", ex);
            }

            child.Text = "Here is your picture";
            child.Show();
            //child.Close();
            //child.Dispose();
            //child.Image.Dispose();
        }

        /// <summary>
        /// Event handler to disable the 'Save' and 'SaveAs' menu items if no child items exist.
        /// 
        /// Source: 
        /// - https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-determine-the-active-mdi-child?view=netframeworkdesktop-4.8 
        /// - https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-disable-toolstripmenuitems?view=netframeworkdesktop-4.8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //if there is no active child form on the parent, disable the 'Save' menu items
            if (this.ActiveMdiChild is null) 
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
            } else
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Allows the user to save the active form as a .jpg file on user's computer. If this was the first
        /// save, then it will ask the user to specify location and filename. 
        /// Source:
        /// - https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=windowsdesktop-6.0 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild child = (FormChild)this.ActiveMdiChild;
            DialogResult re = saveFileDialog_main.ShowDialog();
            saveFileDialog_main.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            saveFileDialog_main.DefaultExt = ".jpg";
            saveFileDialog_main.RestoreDirectory = true;
            Stream myStream;

            if (re == DialogResult.OK)
            {
                if ((myStream = saveFileDialog_main.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }

            child.Close();
            child.Dispose();
        }

        /// <summary>
        /// Allows the user to save the active form as a .jpg file on the user's computer. However, it allows the
        /// user to specify the file name each time this method is invoked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild child = (FormChild)this.ActiveMdiChild;
            DialogResult re = saveFileDialog_main.ShowDialog();
            saveFileDialog_main.FileName = "Document"; // Default file name
            saveFileDialog_main.DefaultExt = ".jpg"; // Default file extension
            saveFileDialog_main.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            // Process open file dialog box results
            if (re == DialogResult.OK)
            {
                //try
                //{
                //    string filename = saveFileDialog_main.FileName;
                    
                //}
                
            }

            child.Close();
            child.Dispose();
        }

        /// <summary>
        /// Cascades all MDI child windows.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.layoutmdi?view=windowsdesktop-6.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Aligns the MDI child windows as horizontal tiles.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.layoutmdi?view=windowsdesktop-6.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Aligns the MDI child windows as vertical tiles.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.layoutmdi?view=windowsdesktop-6.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
