namespace Moyneur_CourseProject_part1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.clearSong = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.webBrowserDisplay = new System.Windows.Forms.WebBrowser();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addButton.Location = new System.Drawing.Point(74, 322);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 46);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(40, 13);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(27, 13);
            this.titleLable.TabIndex = 1;
            this.titleLable.Text = "Title";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(40, 42);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(40, 72);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(40, 108);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            this.yearLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(40, 140);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 5;
            this.urlLabel.Text = "URL";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(92, 13);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(160, 20);
            this.titleText.TabIndex = 6;
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(92, 42);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(160, 20);
            this.artistText.TabIndex = 7;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(92, 108);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(160, 20);
            this.yearText.TabIndex = 9;
            this.yearText.TextChanged += new System.EventHandler(this.yearText_TextChanged);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(92, 140);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(160, 20);
            this.urlText.TabIndex = 10;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(545, 10);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(387, 222);
            this.outputText.TabIndex = 11;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.Location = new System.Drawing.Point(545, 257);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(387, 186);
            this.songList.TabIndex = 12;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.allSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSongsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allSongsButton.Location = new System.Drawing.Point(78, 398);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(173, 44);
            this.allSongsButton.TabIndex = 13;
            this.allSongsButton.Text = "Show all songs";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(269, 322);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(140, 46);
            this.findButton.TabIndex = 14;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearSong
            // 
            this.clearSong.Location = new System.Drawing.Point(269, 398);
            this.clearSong.Name = "clearSong";
            this.clearSong.Size = new System.Drawing.Size(139, 44);
            this.clearSong.TabIndex = 15;
            this.clearSong.Text = "Clear";
            this.clearSong.UseVisualStyleBackColor = true;
            this.clearSong.Click += new System.EventHandler(this.clearSong_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Pop ",
            "Rock",
            "Country",
            "Chrismas",
            "Metal",
            "Jaz",
            "Rap",
            "Techno",
            "Dubstep",
            "House"});
            this.genreComboBox.Location = new System.Drawing.Point(92, 72);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(159, 21);
            this.genreComboBox.TabIndex = 16;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genraComboBox_SelectedIndexChanged);
            // 
            // webBrowserDisplay
            // 
            this.webBrowserDisplay.Location = new System.Drawing.Point(988, 19);
            this.webBrowserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay.Name = "webBrowserDisplay";
            this.webBrowserDisplay.Size = new System.Drawing.Size(280, 280);
            this.webBrowserDisplay.TabIndex = 17;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(1004, 338);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(108, 60);
            this.playButton.TabIndex = 18;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 485);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webBrowserDisplay);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.clearSong);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.addButton);
            this.Name = "mainForm";
            this.Text = "Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearSong;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.WebBrowser webBrowserDisplay;
        private System.Windows.Forms.Button playButton;
    }
}

