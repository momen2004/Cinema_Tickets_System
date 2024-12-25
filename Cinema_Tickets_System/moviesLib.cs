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
        private void AddMovieTolist(string movieName, int imageIndex)
        {
            ListViewItem movie = new ListViewItem(movieName, imageIndex); //If we want the image name say string imageKey
           
            listViewMovies.Items.Add(movie);
        }


        private void moviesLib_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void moviesLib_Load(object sender, EventArgs e)
        {
            listBoxDays.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDays.SelectedItem != null)
            {
                string selectedDay = listBoxDays.SelectedItem.ToString();
              
                listViewMovies.Items.Clear();
                //if (selectedDay == "Saturday")
                //{
                //    AddMovieTolist("Chriss the swiss", 0);
                //    AddMovieTolist("Chucky",1);
                //    AddMovieTolist("Mulan", 30);
                //}
                //else if(selectedDay == "Sunday")
                //{

                //}
                switch (selectedDay)
                {
                    case "Saturday":
                        AddMovieTolist("Chriss the swiss", 0);
                        AddMovieTolist("Case of chucky", 1);
                        break;
                    case "Sunday":
                        AddMovieTolist("Siccin 7", 31);
                        AddMovieTolist("John wick", 28);
                        break;
                    case "Monday":
                        AddMovieTolist("Wreek it ralph", 40);
                        break;
                    case "Tuesday":
                        AddMovieTolist("Winne the pooh", 39);
                        break;
                    case "Wednesday":
                        AddMovieTolist("Toy story 2", 36);
                        break;
                    case "Thursday":
                        AddMovieTolist("Toy story 1", 35);
                        break;
                    case "Friday":
                        MessageBox.Show("No movies available for the selected day");
                        break;
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

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
