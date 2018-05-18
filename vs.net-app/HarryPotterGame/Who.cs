using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryPotterGame
{
    public partial class Who : Form
    {
        public Who()
        {
            InitializeComponent();
            InitialForm.whoAnsweredCorrect = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitialForm.whoAnsweredCorrect = 1;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InitialForm.whoAnsweredCorrect = 2;
            this.Close();
        }

    }
}
