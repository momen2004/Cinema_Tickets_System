using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema_Tickets_System
{
    public partial class moviesLib : Form
    {
        public moviesLib()
        {
            InitializeComponent();
        }
        private void AddMovieTolist(string movieName, string imageKey, string time, string description , int seats )
        {
            ListViewItem movie = new ListViewItem(movieName, imageKey); //If we want the image indzx say int imageindx in the imageList
            movie.SubItems.Add(time); 
            movie.SubItems.Add(description); 
            movie.SubItems.Add(seats.ToString()); 
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
                        AddMovieTolist("Chriss the swiss", "Chris the swiss.jpg", "9:00 pm", "Croatia, 7th of January 1992: In the middle of the war, a young journalist's body is discovered dressed in the uniform of an international mercenary group. Twenty years later, his cousin Anja Kofmel investigates his story.", 12);
                        AddMovieTolist("Case of chucky", "Curse of Chucky.jpg", "11:00 pm", "After the passing of her mother, Nica Pierce, a young woman in a wheelchair, is forced to deal with her sister, brother-in-law, niece and their nanny as they say their goodbyes to mother. But when people start turSee more", 25);
                        AddMovieTolist("Inside out", "Inside out.jpg", "3:00 pm", "Growing up can be a bumpy road, and it's no exception for Riley, who is uprooted from her Midwest life when her father starts a new job in San Francisco. Riley's guiding emotions— Joy, Fear, Anger, Disgust and SadnSee more",16);
                        AddMovieTolist("The maze runner", "The maze runner.jpg", "6:00 pm", "Set in a post-apocalyptic world, young Thomas is deposited in a community of boys after his memory is erased, soon learning they're all trapped in a maze that will require him to join forces with fellow “runners” for a shot at escape.",10);
                        break;
                    case "Sunday":
                        AddMovieTolist("Siccin 7", "Siccin 7.jpg", "9:00 pm", "A woman intent on fulfilling the conditions of a ritual insinuates herself into a family home.", 26);
                        AddMovieTolist("Toy story That time forgot", "Toy story That time forgot.jpg", "11:00 pm", "During a post-Christmas play date, the gang find themselves in uncharted territory when the coolest set of action figures ever turn out to be dangerously delusional. It's all up to Trixie, the triceratops, if the gang hopes to return to Bonnie's room in this Toy Story That Time Forgot.",12);
                        AddMovieTolist("John wick 4", "John wick 4.jpg", "6:00 pm", "With the price on his head ever increasing, John Wick uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.See less", 4);
                        break;
                    case "Monday":
                        AddMovieTolist("Wreek it ralph", "Wreek it ralph.jpg", "9:00 pm", "Wreck-It Ralph is the 9-foot-tall, 643-pound villain of an arcade video game named Fix-It Felix Jr., in which the game's titular hero fixes buildings that Ralph destroys. Wanting to prove he can be a good guy and not just a villain, Ralph escapes his game and lands in Hero's Duty, a first-person shooter where he helps the game's hero battle against alien invaders. He later enters Sugar Rush, a kart racing game set on tracks made of candies, cookies and other sweets. There, Ralph meets Vanellope von Schweetz who has learned that her game is faced with a dire threat that could affect the entire arcade, and one that Ralph may have inadvertently started.", 20);
                        AddMovieTolist("Toy story 4", "TS4.jpg", "11:00 pm", "Woody has always been confident about his place in the world and that his priority is taking care of his kid, whether that's Andy or Bonnie. But when Bonnie adds a reluctant new toy called \"Forky\" to her room, a road trip adventure alongside old and new friends will show Woody how big the world can be for a toy.",10);
                        AddMovieTolist("Final destination 2", "Final destination 2.jpg", "6:00 pm", "When Kimberly has a violent premonition of a highway pileup she blocks the freeway, keeping a few others meant to die, safe...Or are they? The survivors mysteriously start dying and it's up to Kimberly to stop it before she's next.", 14);
                        break;
                    case "Tuesday":
                        AddMovieTolist("Winne the pooh 2", "Winne the pooh.jpg", "3:00 pm", "Five months following the murders, Christopher Robin tries returning to his regular life while dealing with his PTSD. Deep within the 100-Acre-Wood, a destructive rage grows as Winnie-the-Pooh, Piglet, Owl, and Tigger find their home and their lives endangered after their existence is revealed.",15);
                        AddMovieTolist("Toy story 4", "TS4.jpg", "9:00 pm", "Woody has always been confident about his place in the world and that his priority is taking care of his kid, whether that's Andy or Bonnie. But when Bonnie adds a reluctant new toy called \"Forky\" to her room, a road trip adventure alongside old and new friends will show Woody how big the world can be for a toy",12);
                        AddMovieTolist("Final destination 2", "Final destination 2.jpg", "11:00 pm", "When Kimberly has a violent premonition of a highway pileup she blocks the freeway, keeping a few others meant to die, safe...Or are they? The survivors mysteriously start dying and it's up to Kimberly to stop it before she's next", 20);
                        break;
                    case "Wednesday":
                        AddMovieTolist("Toy story 2", "TS2.jpg", "3:00 pm", "Andy heads off to Cowboy Camp, leaving his toys to their own devices. Things shift into high gear when an obsessive toy collector named Al McWhiggen, owner of Al's Toy Barn kidnaps Woody. Andy's toys mount a daring rescue mission, Buzz Lightyear meets his match and Woody has to decide where he and his heart truly belong.",6);
                        AddMovieTolist("John wick 4", "John wick 4.jpg", "9:00 pm", "With the price on his head ever increasing, John Wick uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.See less", 6);

                        break;
                    case "Thursday":
                        AddMovieTolist("Toy story 1", "TS.jpg", "3:00 pm", "Andy heads off to Cowboy Camp, leaving his toys to their own devices. Things shift into high gear when an obsessive toy collector named Al McWhiggen, owner of Al's Toy Barn kidnaps Woody. Andy's toys mount a daring rescue mission, Buzz Lightyear meets his match and Woody has to decide where he and his heart truly belong.", 6);
                        AddMovieTolist("Chriss the swiss", "Chris the swiss.jpg", "9:00 pm", "Croatia, 7th of January 1992: In the middle of the war, a young journalist's body is discovered dressed in the uniform of an international mercenary group. Twenty years later, his cousin Anja Kofmel investigates his story.", 12);
                        AddMovieTolist("Case of chucky", "Curse of Chucky.jpg", "11:00 pm", "After the passing of her mother, Nica Pierce, a young woman in a wheelchair, is forced to deal with her sister, brother-in-law, niece and their nanny as they say their goodbyes to mother. But when people start turSee more", 25);
                        AddMovieTolist("Inside out", "Inside out.jpg", "3:00 pm", "Growing up can be a bumpy road, and it's no exception for Riley, who is uprooted from her Midwest life when her father starts a new job in San Francisco. Riley's guiding emotions— Joy, Fear, Anger, Disgust and SadnSee more", 16);
                        AddMovieTolist("The maze runner", "The maze runner.jpg", "6:00 pm", "Set in a post-apocalyptic world, young Thomas is deposited in a community of boys after his memory is erased, soon learning they're all trapped in a maze that will require him to join forces with fellow “runners” for a shot at escape.", 10);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {            
                if (listViewMovies.SelectedItems.Count > 0)
                {
                var selectedItem = listViewMovies.SelectedItems[0];
                string name = selectedItem.Text;
                Image img = null;
                string desc = "";
                int seats = 0;
                string time = "";
                if (!string.IsNullOrEmpty(selectedItem.ImageKey))
                {
                    img = listViewMovies.LargeImageList.Images[selectedItem.ImageKey];
                }
                if (selectedItem.SubItems.Count > 1)
                {
                    time = selectedItem.SubItems[1].Text;
                }
                if (selectedItem.SubItems.Count > 2)
                {
                    desc = selectedItem.SubItems[2].Text; 
                }
                if (selectedItem.SubItems.Count > 3)
                {
                    int.TryParse(selectedItem.SubItems[3].Text, out seats); 
                }
                Movie_Details m1 = new Movie_Details(img, name, time ,desc, seats);
                m1.ShowDialog();    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listViewMovies_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
