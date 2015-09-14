using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////
//   Craig Rondinelli    //
//       CIS 202         //
//         DRAW          //
///////////////////////////

namespace Rondinelli_Draw
{
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();

            //Selects white radio button as default
            radWhite.Checked = true;

            //Sets Clear as 'ESC' and Rectangle as 'Enter'
            this.CancelButton = btnClear;
            this.AcceptButton = btnRectangle;
        }
            //Defines random number generator for program
            Random rnd = new Random();

            //Random number variables for color
            int a, r, g, b;
            
            //Random number variables for coordinates and size
            int x, y, w, h;
          
       //Generates random sized, placed, and colored rectangles to the amount entered in textbox
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                int loop = int.Parse(txtIn.Text);

                while (loop > 0)
                {
                    a = rnd.Next(90, 255);
                    r = rnd.Next(0, 255);
                    g = rnd.Next(0, 255);
                    b = rnd.Next(0, 255);
                    x = rnd.Next(0, panDraw.Width - 20);
                    y = rnd.Next(0, panDraw.Height - 20);
                    w = rnd.Next(10, 300);
                    h = rnd.Next(10, 300);


                    Graphics rectangle = panDraw.CreateGraphics();

                    Brush rec = new SolidBrush(Color.FromArgb(a, r, g, b));

                    rectangle.FillRectangle(rec, x, y, w, h);

                    loop--;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers can go here!");
            }

        }

        //Generates random sized, placed, and colored circles to the amount entered in textbox
        private void btnEllipsis_Click(object sender, EventArgs e)
        {
            try
            {
                int loop = int.Parse(txtIn.Text);

                while (loop > 0)
                {
                    a = rnd.Next(90, 255);
                    r = rnd.Next(0, 255);
                    g = rnd.Next(0, 255);
                    b = rnd.Next(0, 255);
                    x = rnd.Next(0, panDraw.Width - 20);
                    y = rnd.Next(0, panDraw.Height - 20);
                    w = rnd.Next(10, 300);
                    h = rnd.Next(10, 300);


                    Graphics ellipse = panDraw.CreateGraphics();

                    Brush elp = new SolidBrush(Color.FromArgb(a, r, g, b));

                    ellipse.FillEllipse(elp, x, y, w, h);

                    loop--;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers can go here!");
            }
        }

        //Clears panel and textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIn.Text = "";
            panDraw.Invalidate();
            txtIn.Focus();
        }

        //When selected, sets form background to white
        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            panDraw.BackColor = System.Drawing.Color.White;
        }

        //When selected, sets form background to gray
        private void radGray_CheckedChanged(object sender, EventArgs e)
        {
            panDraw.BackColor = System.Drawing.Color.Gray;
        }

        //Exits program with confirmation
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm;

            confirm = MessageBox.Show("Are you sure you want to exit? ","",  MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                this.Close();
        }
    }
}
