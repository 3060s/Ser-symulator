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

        private void UpdateScore(double term = 0.0)
        {
            _score += term;
            ScoreLabel.Text = _score.ToString();
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
            // TODO: Zamiast ukrywać ten label zmień jego treść na koszt upgrade 
            label4.Hide();
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
            // TODO: Zamiast ukrywać ten label zmień jego treść na koszt upgrade 
            label5.Hide(); 
            Ulepszenie2.Show();

            UpdateScore(-_worker2Price);

            Timer2.Interval = 250;
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // TODO: Czy ta jedynka nie powinna być stałą?
            UpdateScore(1 * _multiplier1);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // TODO: Czy ta trójka nie powinna być stałą?
            UpdateScore(3 * _multiplier2);
        }
    }
}
