using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorZakat
{
    public partial class Form1 : Form
    {
        class Data
        {
            int penghasilan;
            int pengeluaran;
            int beras;
            int besarnishab;
            double zakat;

            public void setPenghasilan (int val)
            {
                this.penghasilan = val;
            }

            public void setPengeluaran (int val)
            {
                this.pengeluaran = val;
            }
               
            public void setBeras (int val)
            {
                this.beras = val;
            }
            public void setBesarNishab (int val)
            {
                this.besarnishab = val;
            }
            public void setZakat (double val)
            {
                this.zakat = val;
            }

            public int getPenghasilan()
            {
                return penghasilan;
            }
            public int getPengeluaran()
            {
                return pengeluaran;
            }
            public int getBeras()
            {
                return beras;
            }
            public int getBesarNishab()
            {
                return besarnishab;
            }
            public double getZakat()
            {
                return zakat;
            }
            public string getBesarNishabS()
            {
                return besarnishab.ToString();
            }
            public string getZakatS()
            {
                return zakat.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        Data z = new Data();

        public int hitungbesarnishab(int val)
        {
            return val * 522;
        }

        public double hitungzakat(double val1, double val2)
        {
            return (val1 - val2) * 2.5 / 100;
        }
        private void Hitung_Click_1(object sender, EventArgs e)
        {

            z.setBeras(int.Parse(hargaberas.Text));
            z.setPengeluaran(int.Parse(pengeluaranperbulan.Text));
            z.setPenghasilan(int.Parse(penghasilanperbulan.Text));
            z.setBesarNishab(hitungbesarnishab((int.Parse(hargaberas.Text))));
            /*z.setZakat(((double.Parse(penghasilanperbulan.Text)) - (double.Parse(pengeluaranperbulan.Text))) * 2.5 / 100);*/
            z.setZakat(hitungzakat(double.Parse(penghasilanperbulan.Text), (double.Parse(pengeluaranperbulan.Text))));

            besarnishab.Text = z.getBesarNishabS();

            if((z.getPenghasilan()) - (z.getPengeluaran()) < z.getBesarNishab())
            {
                wajibtidak.Text = "TIDAK";
                zakatyangdibayar.Text = "0";
            }

            if ((z.getPenghasilan()) - (z.getPengeluaran()) > z.getBesarNishab())
            {
                wajibtidak.Text = "YA";
                zakatyangdibayar.Text = z.getZakatS();
            }

        }

        private void Besarnishab_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hargaberas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Penghasilanperbulan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Pengeluaranperbulan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
