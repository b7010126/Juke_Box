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
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        StreamReader inputStream = File.OpenText(@"C:E:\To be done\Programming\Juke_Box\Juke_Box\Assignment 2 My Juke Box\Media_TEXT");//location  of the media text file
        NumberofGenre = Convert.ToInt32(inputStream.ReadLine());
        mediaLibrary = new ListBox[NumberofGenre];//creates new list box
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
}
