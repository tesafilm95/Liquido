using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        double d_teilmengebase;
        double d_teilmengearoma;
        double d_teilmengenikotin;
        double d_baseohnenikotin;
        double d_shot_nikotin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                if (!cb_aroma.Checked && !cb_liquid.Checked && !cb_nikotin.Checked)
                {
                    tb_aroma.Enabled = false;
                    tb_nikotin.Enabled = false;
                    tb_nikotingehalt.Enabled = false;
                    tb_nikotinshot.Enabled = false;
                    tb_base.Enabled = false;
                } else
                {
                    tb_aroma.Enabled = true;
                    tb_nikotin.Enabled = true;
                    tb_nikotingehalt.Enabled = true;
                    tb_nikotinshot.Enabled = true;
                    tb_base.Enabled = true;
                }
        }

        private void lb_base_Click(object sender, EventArgs e)
        {

        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
        //Fall: Normale Berechnung
            if (cb_aroma.Checked == false && cb_liquid.Checked == false && cb_nikotin.Checked == false)
            {
                //Eingabe
                double d_gesamtmenge = double.Parse(tb_gesamtmenge.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_prozent = double.Parse(tb_prozent.Text, System.Globalization.CultureInfo.InvariantCulture);

                //Verarbeitung
                d_teilmengebase = (1 - (d_prozent / 100)) * d_gesamtmenge;
                d_teilmengearoma = (d_prozent / 100) * d_gesamtmenge;

                //Ausgabe
                this.tb_aroma.Text = d_teilmengearoma.ToString("n");
                this.tb_base.Text = d_teilmengebase.ToString("n");
            }
        //Fall: Aroma
            if (cb_aroma.Checked == true && cb_liquid.Checked == false && cb_nikotin.Checked == false)
            {
                //Eingabe
                double d_aroma = double.Parse(tb_aroma.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_prozent = double.Parse(tb_prozent.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_gesamtmenge = double.Parse(tb_gesamtmenge.Text, System.Globalization.CultureInfo.InvariantCulture);

                //Verarbeitung
                d_gesamtmenge = d_aroma / (d_prozent / 100);
                d_teilmengebase = d_gesamtmenge - d_aroma;

                //Ausgabe
                this.tb_gesamtmenge.Text = d_gesamtmenge.ToString("n");
                this.tb_base.Text = d_teilmengebase.ToString("n");
            }
        //Fall: Liquid
            if (cb_aroma.Checked == false && cb_liquid.Checked == true && cb_nikotin.Checked == false)
            {
                //Eingabe
                double d_base = double.Parse(tb_base.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_prozent = double.Parse(tb_prozent.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_gesamtmenge = double.Parse(tb_gesamtmenge.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_aroma = double.Parse(tb_aroma.Text, System.Globalization.CultureInfo.InvariantCulture);

                //Verarbeitung
                d_aroma = d_base * (d_prozent / 100);
                d_gesamtmenge = d_base + d_aroma; 

                //Ausgabe
                this.tb_gesamtmenge.Text = d_gesamtmenge.ToString("n");
                this.tb_aroma.Text = d_aroma.ToString("n");
            }
        //Fall: Nikotin
            if (cb_aroma.Checked == false && cb_liquid.Checked == false && cb_nikotin.Checked == true)
            {
                //Eingabe
                double d_base = double.Parse(tb_base.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_prozent = double.Parse(tb_prozent.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_gesamtmenge = double.Parse(tb_gesamtmenge.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_aroma = double.Parse(tb_aroma.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_nikotingehalt = double.Parse(tb_nikotingehalt.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d_nikotinshot = double.Parse(tb_nikotinshot.Text, System.Globalization.CultureInfo.InvariantCulture);
                //Verarbeitung

                d_shot_nikotin = d_nikotingehalt * (100 / d_nikotinshot);
                d_teilmengearoma = (d_prozent / 100) * d_gesamtmenge;
                d_teilmengebase = d_gesamtmenge - d_teilmengearoma;
                d_teilmengenikotin = d_teilmengebase * (d_nikotingehalt / 100);
                d_baseohnenikotin = d_teilmengebase - d_shot_nikotin;
                
    

                //Ausgabe
                tb_base.Text = d_baseohnenikotin.ToString("n");
                tb_aroma.Text = d_teilmengearoma.ToString("n");
                tb_nikotin.Text = d_shot_nikotin.ToString("n");
               
            }

        }

        private void tb_aroma_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_nikotin_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_nikotin.Checked)
            {
                tb_nikotin.Enabled = true;
                tb_aroma.Enabled = false;
                tb_base.Enabled = false;
                tb_nikotingehalt.Enabled = true;
                tb_nikotinshot.Enabled = true; 
            }
            else
            {
                tb_aroma.Enabled = false;
                tb_nikotin.Enabled = false;
                tb_nikotingehalt.Enabled = false;
                tb_nikotinshot.Enabled = false;
                tb_base.Enabled = false;
            }
        }

        private void cb_liquid_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_liquid.Checked)
            {
                tb_gesamtmenge.Enabled = false;
                tb_base.Enabled = true; 
                tb_aroma.Enabled = false;
                tb_nikotin.Enabled = false;
                tb_nikotingehalt.Enabled = false;
                tb_nikotinshot.Enabled = false;
            }
            else
            {
                tb_gesamtmenge.Enabled = true;
                tb_aroma.Enabled = false;
                tb_base.Enabled = false;
                tb_nikotin.Enabled = false;
                tb_nikotingehalt.Enabled = false;
                tb_nikotinshot.Enabled = false;
            }
        }

        private void cb_aroma_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_aroma.Checked)
            {
                tb_gesamtmenge.Enabled = false;
                tb_aroma.Enabled = true; 
                tb_base.Enabled = false;
                tb_nikotin.Enabled = false;
                tb_nikotingehalt.Enabled = false;
                tb_nikotinshot.Enabled = false;
            } else
            {
                tb_aroma.Enabled = false;
                tb_gesamtmenge.Enabled = true;
                tb_base.Enabled = false;
                tb_nikotin.Enabled = false;
                tb_nikotingehalt.Enabled = false;
                tb_nikotinshot.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 10;
            trackBar1.LargeChange = 20;
            trackBar1.SmallChange = 10;

            String s_track = Convert.ToString(trackBar1.Value);
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            String s_namearoma = tb_namearoma.Text;
            String s_gesamtmenge = tb_gesamtmenge.Text;
            String s_aroma = tb_aroma.Text;
            String s_base = tb_base.Text;
            String s_nikotingehalt = tb_nikotin.Text;
            String s_aromaprozent = tb_prozent.Text;
            String s_nikotin = tb_nikotin.Text;
            String s_nikotin_shot = tb_nikotinshot.Text;
            String s_kommentar = tb_kommentar.Text;
            String s_track = Convert.ToString(trackBar1.Value);

            DateTime localDate = DateTime.Now;

            string[] lines = { s_namearoma + " - " + localDate.ToString(),
                               "",
                               "Gesamtmenge Liquid:         "+s_gesamtmenge+" ml",
                               "Anteil Aroma:               "+s_aromaprozent+" %",
                               "Menge Aroma:                "+s_aroma+" ml",
                               "Menge Base:                 "+s_base+" ml",
                               "Gewünschter Nikotingehalt:  "+s_nikotingehalt+" mg",
                               "Menge Nikotin:              "+s_nikotin+" ml",
                               "Stärke Nikotinshot:         "+s_nikotin_shot+" mg/ml",
                               "",
                               "Kommentar:",
                               s_kommentar,
                               "",
                               "Weiterempfehlung:           "+s_track+" %"    
            };
            /*
            string text = s_namearoma + " - " + localDate.ToString() +
                "Gesamtmenge Liquid: "+s_gesamtmenge + "\n Anteil Aroma: " + "\n Benötigte Menge Aroma: ";
            */
            System.IO.File.WriteAllLines(@"C:\Users\Suda\Desktop\"+s_namearoma+".txt", lines);
        }
    }
}
