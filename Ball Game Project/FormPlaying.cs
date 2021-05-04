using System;
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
    public partial class FormPlaying : Form
    {
        private string username;
        private bool includeRating;
        private string file;
        private bool light;

        private int _speed = 2;
        private List<int> _direction = new List<int> { 0, 0 };
        private int _score = 0;
        private static Random rand = new Random();

        DateTime startTime;
        private Dictionary<string, TimeSpan> playersData;
        private void spawn()
        {
            rounded_ButtonTheBall.Height -= 10;
            rounded_ButtonTheBall.Width -= 10;
            rounded_ButtonTheBall.ButtonColor = Color.FromArgb(
                    rand.Next(0, 255),
                    rand.Next(0, 255),
                    rand.Next(0, 255)
                );
            rounded_ButtonTheBall.OnHoverButtonColor = rounded_ButtonTheBall.ButtonColor;
            rounded_ButtonTheBall.Location = new Point(
                    rand.Next(1, splitContainer1.ClientSize.Width - (splitContainer1.SplitterDistance + splitContainer1.SplitterWidth) - rounded_ButtonTheBall.Width - 1),
                    rand.Next(1, splitContainer1.ClientSize.Height - rounded_ButtonTheBall.Height - 1)
                );
            _direction[0] = rand.Next(-_speed, _speed);
            _direction[1] = Convert.ToInt32(Math.Sqrt(Math.Pow(_speed, 2) - Math.Pow(_direction[0], 2)));
        }
        private void bounce()
        {
            if (rounded_ButtonTheBall.Location.X + _direction[0] <= 0)
            {
                _direction[0] = Math.Abs(_direction[0]);
            }
            if (rounded_ButtonTheBall.Location.X + _direction[0] >= splitContainer1.ClientSize.Width -
                (splitContainer1.SplitterDistance + splitContainer1.SplitterWidth) - rounded_ButtonTheBall.Width)
            {
                _direction[0] = -Math.Abs(_direction[0]);
            }
            if (rounded_ButtonTheBall.Location.Y + _direction[1] <= 0)
            {
                _direction[1] = Math.Abs(_direction[1]);
            }
            if (rounded_ButtonTheBall.Location.Y + _direction[1] >= splitContainer1.ClientSize.Height - rounded_ButtonTheBall.Height)
            {
                _direction[1] = -Math.Abs(_direction[1]);
            }
        }
        public FormPlaying(string username, bool includeRating, string file, Dictionary<string, TimeSpan> playersData, bool light)
        {
            InitializeComponent();
            this.username = username;
            this.includeRating = includeRating;
            this.file = file;
            this.playersData = playersData;
            this.light = light;
        }

        private void rounded_ButtonTheBall_Click(object sender, EventArgs e)
        {
            labelScoreShow.Text = $"{_score+1}";
            if (_score == 4)
            {
                DateTime endTime = DateTime.Now;
                timer1.Stop();
                timer2.Stop();

                TimeSpan timeSpan = TimeSpan.Parse(labelTimeShow.Text);
                if (includeRating)
                {
                    if (!playersData.ContainsKey(username))
                    {
                        playersData.Add(username, timeSpan);
                        FormRecord record = new FormRecord(timeSpan);

                        record.Show();
                    }
                    else
                    {
                        if(playersData[username] > timeSpan)
                        {
                            playersData[username] = timeSpan;
                            FormRecord record = new FormRecord(timeSpan);
                            
                            record.Show();
                        }
                    }
                    
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, TimeSpan>));
                    Stream stream1 = new FileStream(file, FileMode.Create);
                    serializer.WriteObject(stream1, playersData);
                    stream1.Close();
                }
            }
            else
            {
                spawn();
                _speed += 6;
                _score += 1;     
            }
        }

        private void FormPlaying_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            startTime = DateTime.Now;
            if (this.light)
            {
                splitContainer1.Panel1.BackColor = Color.WhiteSmoke;
                labelTime.ForeColor = Color.FromArgb(9, 24, 34);
                labelTimeShow.ForeColor = Color.FromArgb(9, 24, 34);
                labelScore.ForeColor = Color.FromArgb(9, 24, 34);
                labelScoreShow.ForeColor = Color.FromArgb(9, 24, 34);
                splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
                buttonHome.BackColor = Color.WhiteSmoke;             
            }
            else
            {
                splitContainer1.Panel1.BackColor = Color.FromArgb(9, 24, 34);
                labelTime.ForeColor = Color.White;
                labelTimeShow.ForeColor = Color.White;
                labelScore.ForeColor = Color.White;
                labelScoreShow.ForeColor = Color.White;
                splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
                buttonHome.BackColor = Color.FromArgb(9, 24, 34);
            }
            buttonRestart.Location = new Point(20, 315);
            buttonHome.Location = new Point(20, 390);
            spawn();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rounded_ButtonTheBall.Location = new Point(
                    rounded_ButtonTheBall.Location.X + _direction[0],
                    rounded_ButtonTheBall.Location.Y + _direction[1]
                );
            bounce();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            TimeSpan timeSpan1ms = timeNow.Subtract(startTime);
            labelTimeShow.Text = timeSpan1ms.ToString();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPlaying newGame = new FormPlaying(username, includeRating, file, playersData, light);
            newGame.Show();
        }

    }
}