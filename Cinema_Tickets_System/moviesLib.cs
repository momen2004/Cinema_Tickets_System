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
    public partial class moviesLib : Form
    {
        public moviesLib()
        {
            InitializeComponent();
        }

        private void moviesLib_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void moviesLib_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedDay = listBox1.SelectedItem.ToString();
                if (listBox1.SelectedItem != null)
                {
                    listView1.Visible = (selectedDay == "Sunday"); 
                    listView2.Visible = (selectedDay == "Monday");
                    listView3.Visible = (selectedDay == "Tuesday");
                    listView4.Visible = (selectedDay == "Wednesday");
                    listView5.Visible = (selectedDay == "Thursday");
                    listView6.Visible = (selectedDay == "Saturday");
                    if (selectedDay == "Friday")
                        MessageBox.Show("No movies showing for the selected day");
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SunMovieFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.f1.Show();
        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
