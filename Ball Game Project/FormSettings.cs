using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Game_Project
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void rounded_ButtonHTP_Click(object sender, EventArgs e)
        {
            FormHowToPlay howToPlay = new FormHowToPlay();
            howToPlay.Show();
        }

        private void buttonLight_Click(object sender, EventArgs e)
        {
            buttonLight.BackColor = Color.MediumTurquoise;
            buttonDark.BackColor = Color.FromArgb(64, 64, 64);
            
        }

        private void buttonDark_Click(object sender, EventArgs e)
        {
            buttonLight.BackColor = Color.WhiteSmoke;
            buttonDark.BackColor = Color.MediumTurquoise;
            
        }
    }
}
