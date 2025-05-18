using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = browesChumash.Text;
            Chumashim.Text = "";
            Chumashim.Text += Logic.ChumashSearch(a);
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logic.Find(showRes.Text);
        }

        private void lostLetter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logic.FindWithMoreLetters(showRes.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logic.FindFullWord(showRes.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
