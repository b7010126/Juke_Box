using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;
using System.IO;//i have made this a global variable 

namespace Duke_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            public string MediaPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public int NumberofGenre;
        ListBox[] mediaLibrary;// i have created a string for my media library 

        private void Form1_Load(object sender, EventArgs e)
        {
            string lineOfText;//The location of the application

            int total_number_of_genrea;

            int total_number_of_tracks;//Total number of tracks
            string applicationPath = Directory.GetCurrentDirectory() + "\\Media\\"; // This creates a media file and shows the location

            total_number_of_genrea = Convert.ToInt32(myInputStream.ReadLine());

            mediaLibrary = new ListBox[total_number_of_genrea];

            for (int g = 0; g < total_number_of_genrea; g++)
            {
                mediaLibrary[g] = new ListBox();

                total_number_of_tracks = Convert.ToInt32(myInputStream.ReadLine());

                for (int t = 0; t <= total_number_of_tracks; t++)

                {

                    mediaLibrary[g].Items.Add(myInputStream.ReadLine());

                }
            }



            myInputStream.Close();// closes the file




            Update_interface(2);// update the interface
        }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

      
    }

}

private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();//This opens the setup and then allows us to close after use.
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            myForm.Show();// This opens the about and then allows us to close after use.
        }
    }

