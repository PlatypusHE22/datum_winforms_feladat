using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DatumJatek {
    public partial class Form1 : Form {
        private DateTime szuletesiDatum;
        private DateTime valasztottDatum;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            lblIdo.Text = DateTime.Now.ToString();
            lblUzenet.Text = "";
            valasztottDatum = datePicker.Value;
            ActiveControl = mtbSzuletesiDatum;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            base.OnLoad(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIdo.Text = DateTime.Now.ToString();
        }

        private void mtbSzuletesiDatum_Leave(object sender, EventArgs e)
        {
            try
            {
                szuletesiDatum = DateTime.Parse(mtbSzuletesiDatum.Text);
                if (szuletesiDatum.Month == DateTime.Now.Month && szuletesiDatum.Day == DateTime.Now.Day)
                    lblUzenet.Text = "Boldog születésnapot!";
                else
                    lblUzenet.Text = "Boldog hétköznapot";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hiba");
                mtbSzuletesiDatum.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbKor.Text = (DateTime.Now.Year - szuletesiDatum.Year).ToString();
            tbSzuletesiNap.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(szuletesiDatum.DayOfWeek);
            tbNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztosan ki akarsz lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            valasztottDatum = datePicker.Value;
            tbNapSorszam.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void tbNapSzam_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int nap = int.Parse(tbNapSzam.Text);
                tbKesobbiNap.Text = valasztottDatum.AddDays(nap).ToString("d");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Hiba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
            lblUzenet.Text = "";
            mtbSzuletesiDatum.Clear();
        }
    }
}