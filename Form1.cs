using System;
using System.Windows.Forms;

namespace Clicker_game
{
    public partial class Form1 : Form
    {
        // TODO: Dane o konkretnym pracowniku można zgrupować w jakąś klasę lub strukturę
        //       (potem zrobić tablicę tych pracowników, np. new Worker[])
        private const double _worker1Price = 100.0;
        private const double _worker2Price = 300.0;
        private const int _worker1Efficiency = 1;
        private const int _worker2Efficiency = 3;
        private double _multiplier1 = 1.0;
        private double _multiplier2 = 2.0;
        private int _multiplier1Price = 20;
        private int _multiplier2Price = 40;

        private double _score = 0.0;
        private int _upgradeLevel = 1;
        private double _upgradePrice = 10.0;

        public Form1()
        {
            InitializeComponent();

            UpdateScore();
            UpdateUpgradePrice();
        }

        private void UpdateScore(double term = 0.0)
        {
            _score += term;
            ScoreLabel.Text = $"{_score:F1}";
        }

        private void UpdateUpgradePrice()
        {
            label3.Text = $"Cena ulepszenia: {_upgradePrice} serów";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateScore(_upgradeLevel);
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            if (_score < _upgradePrice)
            {
                return;
            }

            UpdateScore(-_upgradePrice);

            _upgradeLevel++;

            _upgradePrice += 10;
            UpdateUpgradePrice();
        }

        private void pracownik1_Click(object sender, EventArgs e)
        {
            if (_score < _worker1Price)
            {
                return;
            }

            pracownik1.Visible = false;
            label4.Text = $"Cena ulepszenia: {_multiplier1Price} serów";
            Ulepszenie1.Show();

            UpdateScore(-_worker1Price);

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
            label5.Text = $"Cena ulepszenia: {_multiplier2Price} serów";
            Ulepszenie2.Show();

            UpdateScore(-_worker2Price);

            Timer2.Interval = 250;
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateScore(_worker1Efficiency * _multiplier1);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            UpdateScore(_worker2Efficiency * _multiplier2);
        }

        private void Ulepszenie1_Click(object sender, EventArgs e)
        {

            if(_score > _multiplier1Price)
            {
                UpdateScore(-_multiplier1Price);
                _multiplier1Price += 20;
                _multiplier1 += 0.2;
            }

            label4.Text = $"Cena ulepszenia: {_multiplier1Price} serów";
        }

        private void Ulepszenie2_Click(object sender, EventArgs e)
        {
            if (_score > _multiplier2Price)
            {
                UpdateScore(-_multiplier2Price);
                _multiplier2Price += 40;
                _multiplier2 += 0.4;
            }

            label5.Text = $"Cena ulepszenia: {_multiplier2Price} serów";
        }
    }
}
