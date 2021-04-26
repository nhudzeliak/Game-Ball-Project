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
        private Stream stream;

        private int _speed = 1;
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
                    rand.Next(1, ClientSize.Width - rounded_ButtonTheBall.Width - 1),
                    rand.Next(1, ClientSize.Height - rounded_ButtonTheBall.Height - 1)
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
            if (rounded_ButtonTheBall.Location.X + _direction[0] >= ClientSize.Width - rounded_ButtonTheBall.Width)
            {
                _direction[0] = -Math.Abs(_direction[0]);
            }
            if (rounded_ButtonTheBall.Location.Y + _direction[1] <= 0)
            {
                _direction[1] = Math.Abs(_direction[1]);
            }
            if (rounded_ButtonTheBall.Location.Y + _direction[1] >= ClientSize.Height - rounded_ButtonTheBall.Height)
            {
                _direction[1] = -Math.Abs(_direction[1]);
            }
        }
        public FormPlaying(string username, bool includeRating, Stream stream, Dictionary<string, TimeSpan> playersData)
        {
            InitializeComponent();
            this.username = username;
            this.includeRating = includeRating;
            this.stream = stream;
            this.playersData = playersData;
        }

        private void rounded_ButtonTheBall_Click(object sender, EventArgs e)
        {
            if (_score == 4)
            {
                timer1.Stop();
                DateTime endTime = DateTime.Now;
                TimeSpan timeSpan = endTime.Subtract(startTime);
                if (includeRating)
                {
                    if (!playersData.ContainsKey(username))
                    {
                        playersData.Add(username, timeSpan);
                    }
                    else
                    {
                        if(playersData[username] > timeSpan)
                        {
                            playersData[username] = timeSpan;
                        }
                    }
                    
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, TimeSpan>));
                    serializer.WriteObject(stream, playersData);
                }
            }
            else
            {
                spawn();
                _speed += 5;
                _score += 1;
            }
        }

        private void FormPlaying_Load(object sender, EventArgs e)
        {
            timer1.Start();
            startTime = DateTime.Now;
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
    }
}
