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
    public partial class FormRating : Form
    {
        private string file;
        public FormRating(string file)
        {
            InitializeComponent();
            this.file = file;
        }

        private void FormRating_Load(object sender, EventArgs e)
        {
            Stream stream1 = new FileStream(file, FileMode.Open); 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, TimeSpan>));
            stream1.Position = 0;
            var currentRating = (Dictionary<string, TimeSpan>)serializer.ReadObject(stream1);
            stream1.Close();
            var sortedCurrentRating = from entry in currentRating
                            orderby entry.Value ascending
                            select entry;
            int place = 1;
            foreach (var pair in sortedCurrentRating)
            {
                dataGridViewTable.Rows.Add(place, pair.Key, pair.Value);
                if (place == 1)
                {
                    dataGridViewTable.Rows[0].DefaultCellStyle.BackColor = Color.Gold;
                }
                if (place == 2)
                {
                    dataGridViewTable.Rows[1].DefaultCellStyle.BackColor = Color.Silver;
                }
                if (place == 3)
                {
                    dataGridViewTable.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(195, 140, 73);
                }
                place++;
            }
            
        }
    }
}
