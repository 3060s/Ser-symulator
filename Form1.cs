using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_game
{
    public partial class Form1 : Form
    {

        int score = 0;

        int upgrade_level = 1;
        int upgrade_price = 10;

        public Form1()
        {
            InitializeComponent();
            ScoreLabel.Text = score.ToString();
            label3.Text = $"Cena ulepszenia: {upgrade_price} serów";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += upgrade_level;
            ScoreLabel.Text = score.ToString();
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            if (upgrade_price < score)
            {
                score -= upgrade_price;
                ScoreLabel.Text = score.ToString();
                upgrade_level++;
                upgrade_price += 10;
                label3.Text = $"Cena ulepszenia: {upgrade_price} serów";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
