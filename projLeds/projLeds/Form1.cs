using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private Leds meusLeds;
        public Form1()
        {
            InitializeComponent();
            meusLeds = new Leds();
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed1ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(1);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed2ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(2);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed3ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(3);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed4ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(4);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed5ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(5);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed6ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(6);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed7ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(7);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed8ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(8);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed1OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(1);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed2OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(2);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed3OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(3);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed4OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(4);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed5OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(5);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed6OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(6);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed7OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(7);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLed8OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(8);
            txtDado.Text = meusLeds.getDado().ToString();
        }
    }
}
