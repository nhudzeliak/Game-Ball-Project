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
    public partial class FormRecord : Form
    {
        private TimeSpan timeSpan;
        public FormRecord(TimeSpan timeSpan)
        {
            InitializeComponent();
            this.timeSpan = timeSpan;
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            label3.Text = String.Format(@"{0:hh\:mm\:ss\.fff}", timeSpan);
        }
    }
}
