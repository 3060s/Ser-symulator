using System;
using System.Windows.Forms;

namespace Clicker_game
{
    public partial class Form1 : Form
    {
        private const double _worker1Price = 100.0;
        private const double _worker2Price = 300.0;
        private const double _multiplier1 = 1.0;
        private const double _multiplier2 = 1.0;

        private double _score = 0.0;
        private int _upgradeLevel = 1;
        private double _upgradePrice = 10.0;

        public Form1()
        {
            InitializeComponent();

            UpdateScore();
            UpdateUpgradePrice();
        }

        private void UpdateScore()
        {
            ScoreLabel.Text = _score.ToString();
        }

        private void UpdateUpgradePrice()
        {
            label3.Text = $"Cena ulepszenia: {_upgradePrice} serów";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _score += _upgradeLevel;
            UpdateScore();
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            if (_upgradePrice < _score)
            {
                _score -= _upgradePrice;
                UpdateScore();

                _upgradeLevel++;

                _upgradePrice += 10;
                UpdateUpgradePrice();
            }
        }

        private void pracownik1_Click(object sender, EventArgs e)
        {
            if (_score < _worker1Price)
            {
                return;
            }

            pracownik1.Visible = false;
            // TODO: Zamiast ukrywać ten label zmień jego treść na koszt upgrade 
            label4.Hide();
            Ulepszenie1.Show();

            _score -= _worker1Price;
            UpdateScore();

            Timer1.Interval = 250;
            Timer1.Start();
        }

        private void pracownik2_Click(object sender, EventArgs e)
        {
            if (_score < _worker2Price)
            {
                return;
            }

            pracownik2.Visible = false;
            // TODO: Zamiast ukrywać ten label zmień jego treść na koszt upgrade 
            label5.Hide(); 
            Ulepszenie2.Show();

            _score -= _worker2Price;
            UpdateScore();

            Timer2.Interval = 250;
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _score += 1 * _multiplier1;
            UpdateScore();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            _score += 3 * _multiplier2;
            UpdateScore();
        }
    }
}
