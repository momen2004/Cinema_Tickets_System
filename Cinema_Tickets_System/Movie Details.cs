using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Tickets_System
{
    public partial class Movie_Details : Form
    {
        public Movie_Details(Image img, string title, string time, string description, int seats)
        {
            InitializeComponent();
            posterBox.Image = img;
            titleLabel.Text = title;
            richTextBox1.Text = "Description: \n" + description ;
            richTextBox2.Text = "Showing time: \n" + time+'\n'+"Seats available:\n"+seats;
            
        }

        private void Movie_Details_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            reservation res = new reservation(posterBox.Image, titleLabel.Text);
            res.ShowDialog();
        }
    }
}
