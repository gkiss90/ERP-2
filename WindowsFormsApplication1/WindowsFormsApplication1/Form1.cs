using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bolt BoltForm = new Bolt();
        Beszallito BeszallitoForm = new Beszallito();
        Termek TermekForm = new Termek();

        private void btnBolt_Click(object sender, EventArgs e)
        {
            BoltForm.Show();
        }

        private void btnBeszallitok_Click(object sender, EventArgs e)
        {
            BeszallitoForm.Show();
        }

        private void btnTermek_Click(object sender, EventArgs e)
        {
            TermekForm.Show();
        }
    }
}
