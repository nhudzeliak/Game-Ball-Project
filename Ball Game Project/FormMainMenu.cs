﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Ball_Game_Project
{
    public partial class FormMainMenu : Form
    {
        public string currentPlayer;
        private bool goesToRating = true;
        private Stream stream = new FileStream("data.json", FileMode.Open);
        private string file = "data.json";

        private Dictionary<string, TimeSpan> playersData;
        public FormMainMenu()
        {
            InitializeComponent();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, TimeSpan>));
            stream.Position = 0;
            this.playersData = (Dictionary<string, TimeSpan>)serializer.ReadObject(stream);
            stream.Close();
        }
     
        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rounded_ButtonPlay_Click(object sender, EventArgs e)
        {
            currentPlayer = textBoxUser.Text;
            if (currentPlayer == String.Empty)
            {
                DialogResult result = MessageBox.Show("If you do not enter your name your result will not be" +
                    " displayed in the rating. Continue anyway?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    goesToRating = false;
                    FormPlaying playing = new FormPlaying(currentPlayer, false, file, playersData);
                    //this.Hide();
                    playing.Show();
                }

            }
            else
            {
                goesToRating = true;
                FormPlaying playing = new FormPlaying(currentPlayer, true, file, playersData);
                //this.Hide();
                playing.Show();
            }
        }

        private void rounded_ButtonRating_Click(object sender, EventArgs e)
        {
            FormRating formRating = new FormRating(file);

            formRating.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRecord record = new FormRecord(new TimeSpan());
            record.Show();
        }
    }
}
