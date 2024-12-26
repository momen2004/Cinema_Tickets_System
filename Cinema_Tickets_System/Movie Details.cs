﻿using System;
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
            richTextBox1.Text = description ;
            richTextBox2.Text = "Showing time: " + time+'\n'+"Seats available: "+seats;
        }

        private void Movie_Details_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {

        }
    }
}