using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyneur_CourseProject_part1
{
    public partial class mainForm : Form
    {
        string[] titleArray = new string[5];         //song titles
        string[] artistArray = new string[5];        //associated artist
        string[] genreArray = new string[5];         //genre types
        int[] yearArray = new int[5];                // which year
        string[] urlArray = new string[5];           //url
        int songCount=0;

        public mainForm()
        {
            InitializeComponent();
        }
        private bool ValidInput()
        // Return true if title, artist, genre, year, and URL are non-empty, false otherwise
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(titleText.Text))
            {
                // Title is blank
                MessageBox.Show("The song title cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                //Artist is blank
                MessageBox.Show("The artist cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreComboBox.SelectedItem.ToString()))
            {
                //Genre is blank
                MessageBox.Show("The genre cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                //Year is blank
                MessageBox.Show("The year cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                //URL is blank
                MessageBox.Show("The url cannot be blank");
                isValid = false;
            }
                return (isValid);

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";
            if (songCount == titleArray.Length)
            {
                MessageBox.Show("Song list is full!");
            }
            else if(ValidInput())
            {
                // All good! Build the output text
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreComboBox.SelectedItem.ToString();
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                //increment the song counter
                songCount++;

                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreComboBox.SelectedItem.ToString());
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);

                outputText.Text = sb.ToString();
                songList.Items.Add(titleText.Text);
            }
        }
        private int GetSongIndex(string songTitle)
        {
            int songIndex = 0;
            songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }


        private bool SongInList(string songTitle)
        {
            bool inList = false;
            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                if (currentSong == songTitle)
                {
                    inList = true;
                }
            }
            return inList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            string nl = "\r\n";
            int songIndex = -1;
            songIndex = GetSongIndex(titleText.Text);

            songIndex = songList.SelectedIndex;
               
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex].ToString());
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);
                outputText.Text = sb.ToString();

            
        }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";


            //Build the output text

            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);

            }

            // Put the ouput text into the output textbox
            outputText.Text = sb.ToString();
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";
            int songIndex = 0;

            if (SongInList(titleText.Text))
            {
                songIndex = GetSongIndex(titleText.Text);
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex].ToString());
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);
                outputText.Text = sb.ToString();
                
            }
            else
            {
                MessageBox.Show("Song not in list");
            }
        }

        private void clearSong_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            artistText.Text = "";
            
            yearText.Text = "";
            urlText.Text = "";
        }

        private void yearText_TextChanged(object sender, EventArgs e)
        {

        }

        private void genraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = 0;
            songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webBrowserDisplay.Navigate(url);
        }
    }
}
