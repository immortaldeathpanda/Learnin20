using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learnin20
{
    public partial class Form1 : Form
    {
        private int goatnumber;
        public Form1()
        {
            InitializeComponent();

            goatnumber = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyGoats_Click(object sender, EventArgs e)
        {
            goatnumber += 1;
            lblGoatCounter.Text = goatnumber.ToString();
            this.BackgroundImage = new Bitmap(@"C:\Users\Admin\Pictures\Games\goats2.bmp");
            
        }

        private void btnSellGoats_Click(object sender, EventArgs e)
        {
            if (goatnumber > 0)
            {
                goatnumber -= 1;
                lblGoatCounter.Text = goatnumber.ToString();
            }
            else lblGoatCounter.Text = "You can't sell goats you don't have you pleb.";
        
}

        private void lblGoatsCommentary_Click(object sender, EventArgs e)
        
            {
                
            }

    }
}






