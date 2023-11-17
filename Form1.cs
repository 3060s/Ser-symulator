using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Clicker_game
{
    public partial class Form1 : Form
    {

        int score = 0;

        int upgrade_level = 1;
        int upgrade_price = 10;
        int pracownik1_cena = 100;
        int pracownik2_cena = 300;


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

        private void pracownik1_Click(object sender, EventArgs e)
        {
            if (pracownik1_cena < score)
            {
                pracownik1.Visible = false;
                label4.Hide();
                score -= pracownik1_cena;
                ScoreLabel.Text = score.ToString();
                Timer1.Interval = 250;
                Timer1.Start();
            }
        }

        private void pracownik2_Click(object sender, EventArgs e)
        {
            if (pracownik2_cena < score)
            {
                pracownik2.Visible = false;
                label5.Hide();
                score -= pracownik2_cena;
                ScoreLabel.Text = score.ToString();
                Timer2.Interval = 250;
                Timer2.Start();
            }



        }


        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            score++;
            ScoreLabel.Text = score.ToString();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            score++;
            score++;
            score++;
            ScoreLabel.Text = score.ToString();
        }
    }
}
