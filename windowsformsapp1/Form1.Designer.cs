namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_gesamtmenge = new System.Windows.Forms.TextBox();
            this.tb_aroma = new System.Windows.Forms.TextBox();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.tb_prozent = new System.Windows.Forms.TextBox();
            this.lb_gesamtmenge = new System.Windows.Forms.Label();
            this.lb_aroma = new System.Windows.Forms.Label();
            this.lb_base = new System.Windows.Forms.Label();
            this.lb_prozent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nikotin = new System.Windows.Forms.TextBox();
            this.lb_ml1 = new System.Windows.Forms.Label();
            this.lb_ml2 = new System.Windows.Forms.Label();
            this.lb_ml3 = new System.Windows.Forms.Label();
            this.lb_ml4 = new System.Windows.Forms.Label();
            this.lb_pro = new System.Windows.Forms.Label();
            this.cb_nikotin = new System.Windows.Forms.CheckBox();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.tb_nikotingehalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_liquid = new System.Windows.Forms.CheckBox();
            this.cb_aroma = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nikotinshot = new System.Windows.Forms.TextBox();
            this.tb_kommentar = new System.Windows.Forms.RichTextBox();
            this.tb_namearoma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_speichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_gesamtmenge
            // 
            this.tb_gesamtmenge.Location = new System.Drawing.Point(247, 14);
            this.tb_gesamtmenge.Name = "tb_gesamtmenge";
            this.tb_gesamtmenge.Size = new System.Drawing.Size(39, 20);
            this.tb_gesamtmenge.TabIndex = 1;
            this.tb_gesamtmenge.Text = "0";
            this.tb_gesamtmenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_aroma
            // 
            this.tb_aroma.BackColor = System.Drawing.SystemColors.Window;
            this.tb_aroma.Location = new System.Drawing.Point(247, 66);
            this.tb_aroma.Name = "tb_aroma";
            this.tb_aroma.Size = new System.Drawing.Size(39, 20);
            this.tb_aroma.TabIndex = 2;
            this.tb_aroma.Text = "0";
            this.tb_aroma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_aroma.TextChanged += new System.EventHandler(this.tb_aroma_TextChanged);
            // 
            // tb_base
            // 
            this.tb_base.BackColor = System.Drawing.SystemColors.Window;
            this.tb_base.Location = new System.Drawing.Point(247, 92);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(39, 20);
            this.tb_base.TabIndex = 3;
            this.tb_base.Text = "0";
            this.tb_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_prozent
            // 
            this.tb_prozent.Location = new System.Drawing.Point(247, 40);
            this.tb_prozent.Name = "tb_prozent";
            this.tb_prozent.Size = new System.Drawing.Size(39, 20);
            this.tb_prozent.TabIndex = 4;
            this.tb_prozent.Text = "0";
            this.tb_prozent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_gesamtmenge
            // 
            this.lb_gesamtmenge.AutoSize = true;
            this.lb_gesamtmenge.Location = new System.Drawing.Point(12, 17);
            this.lb_gesamtmenge.Name = "lb_gesamtmenge";
            this.lb_gesamtmenge.Size = new System.Drawing.Size(78, 13);
            this.lb_gesamtmenge.TabIndex = 6;
            this.lb_gesamtmenge.Text = "Gesamtmenge:";
            // 
            // lb_aroma
            // 
            this.lb_aroma.AutoSize = true;
            this.lb_aroma.Location = new System.Drawing.Point(12, 69);
            this.lb_aroma.Name = "lb_aroma";
            this.lb_aroma.Size = new System.Drawing.Size(76, 13);
            this.lb_aroma.TabIndex = 7;
            this.lb_aroma.Text = "Menge Aroma:";
            // 
            // lb_base
            // 
            this.lb_base.AutoSize = true;
            this.lb_base.Location = new System.Drawing.Point(12, 95);
            this.lb_base.Name = "lb_base";
            this.lb_base.Size = new System.Drawing.Size(99, 13);
            this.lb_base.TabIndex = 8;
            this.lb_base.Text = "Menge Base (0mg):";
            this.lb_base.UseWaitCursor = true;
            this.lb_base.Click += new System.EventHandler(this.lb_base_Click);
            // 
            // lb_prozent
            // 
            this.lb_prozent.AutoSize = true;
            this.lb_prozent.Location = new System.Drawing.Point(12, 43);
            this.lb_prozent.Name = "lb_prozent";
            this.lb_prozent.Size = new System.Drawing.Size(131, 13);
            this.lb_prozent.TabIndex = 9;
            this.lb_prozent.Text = "Prozentualer Anteil Aroma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nikotin:";
            // 
            // tb_nikotin
            // 
            this.tb_nikotin.Location = new System.Drawing.Point(247, 144);
            this.tb_nikotin.Name = "tb_nikotin";
            this.tb_nikotin.Size = new System.Drawing.Size(39, 20);
            this.tb_nikotin.TabIndex = 5;
            this.tb_nikotin.Text = "0";
            this.tb_nikotin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_ml1
            // 
            this.lb_ml1.AutoSize = true;
            this.lb_ml1.Location = new System.Drawing.Point(292, 17);
            this.lb_ml1.Name = "lb_ml1";
            this.lb_ml1.Size = new System.Drawing.Size(17, 13);
            this.lb_ml1.TabIndex = 12;
            this.lb_ml1.Text = "ml";
            // 
            // lb_ml2
            // 
            this.lb_ml2.AutoSize = true;
            this.lb_ml2.Location = new System.Drawing.Point(292, 147);
            this.lb_ml2.Name = "lb_ml2";
            this.lb_ml2.Size = new System.Drawing.Size(17, 13);
            this.lb_ml2.TabIndex = 13;
            this.lb_ml2.Text = "ml";
            // 
            // lb_ml3
            // 
            this.lb_ml3.AutoSize = true;
            this.lb_ml3.Location = new System.Drawing.Point(292, 69);
            this.lb_ml3.Name = "lb_ml3";
            this.lb_ml3.Size = new System.Drawing.Size(17, 13);
            this.lb_ml3.TabIndex = 14;
            this.lb_ml3.Text = "ml";
            // 
            // lb_ml4
            // 
            this.lb_ml4.AutoSize = true;
            this.lb_ml4.Location = new System.Drawing.Point(292, 95);
            this.lb_ml4.Name = "lb_ml4";
            this.lb_ml4.Size = new System.Drawing.Size(17, 13);
            this.lb_ml4.TabIndex = 15;
            this.lb_ml4.Text = "ml";
            // 
            // lb_pro
            // 
            this.lb_pro.AutoSize = true;
            this.lb_pro.Location = new System.Drawing.Point(292, 43);
            this.lb_pro.Name = "lb_pro";
            this.lb_pro.Size = new System.Drawing.Size(15, 13);
            this.lb_pro.TabIndex = 16;
            this.lb_pro.Text = "%";
            // 
            // cb_nikotin
            // 
            this.cb_nikotin.AutoSize = true;
            this.cb_nikotin.Location = new System.Drawing.Point(13, 202);
            this.cb_nikotin.Name = "cb_nikotin";
            this.cb_nikotin.Size = new System.Drawing.Size(59, 17);
            this.cb_nikotin.TabIndex = 11;
            this.cb_nikotin.Text = "Nikotin";
            this.cb_nikotin.UseVisualStyleBackColor = true;
            this.cb_nikotin.CheckedChanged += new System.EventHandler(this.cb_nikotin_CheckedChanged);
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(187, 459);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(75, 23);
            this.btn_berechnen.TabIndex = 0;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // tb_nikotingehalt
            // 
            this.tb_nikotingehalt.Location = new System.Drawing.Point(247, 118);
            this.tb_nikotingehalt.Name = "tb_nikotingehalt";
            this.tb_nikotingehalt.Size = new System.Drawing.Size(39, 20);
            this.tb_nikotingehalt.TabIndex = 17;
            this.tb_nikotingehalt.Text = "0";
            this.tb_nikotingehalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_nikotingehalt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "mg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gewünschter Nikotingehalt:";
            this.label3.UseWaitCursor = true;
            // 
            // cb_liquid
            // 
            this.cb_liquid.AutoSize = true;
            this.cb_liquid.Location = new System.Drawing.Point(78, 202);
            this.cb_liquid.Name = "cb_liquid";
            this.cb_liquid.Size = new System.Drawing.Size(54, 17);
            this.cb_liquid.TabIndex = 20;
            this.cb_liquid.Text = "Liquid";
            this.cb_liquid.UseVisualStyleBackColor = true;
            this.cb_liquid.CheckedChanged += new System.EventHandler(this.cb_liquid_CheckedChanged);
            // 
            // cb_aroma
            // 
            this.cb_aroma.AutoSize = true;
            this.cb_aroma.Location = new System.Drawing.Point(138, 202);
            this.cb_aroma.Name = "cb_aroma";
            this.cb_aroma.Size = new System.Drawing.Size(56, 17);
            this.cb_aroma.TabIndex = 21;
            this.cb_aroma.Text = "Aroma";
            this.cb_aroma.UseVisualStyleBackColor = true;
            this.cb_aroma.CheckedChanged += new System.EventHandler(this.cb_aroma_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "mg/ml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nikotinshot:";
            // 
            // tb_nikotinshot
            // 
            this.tb_nikotinshot.Location = new System.Drawing.Point(247, 170);
            this.tb_nikotinshot.Name = "tb_nikotinshot";
            this.tb_nikotinshot.Size = new System.Drawing.Size(39, 20);
            this.tb_nikotinshot.TabIndex = 22;
            this.tb_nikotinshot.Text = "0";
            this.tb_nikotinshot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_kommentar
            // 
            this.tb_kommentar.Location = new System.Drawing.Point(15, 269);
            this.tb_kommentar.Name = "tb_kommentar";
            this.tb_kommentar.Size = new System.Drawing.Size(328, 96);
            this.tb_kommentar.TabIndex = 25;
            this.tb_kommentar.Text = "";
            // 
            // tb_namearoma
            // 
            this.tb_namearoma.Location = new System.Drawing.Point(78, 230);
            this.tb_namearoma.Name = "tb_namearoma";
            this.tb_namearoma.Size = new System.Drawing.Size(100, 20);
            this.tb_namearoma.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aroma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Kommentar:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(15, 384);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(328, 45);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Weiterempfehlungsrate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "100%";
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(268, 459);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(75, 23);
            this.btn_speichern.TabIndex = 33;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 494);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_namearoma);
            this.Controls.Add(this.tb_kommentar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nikotinshot);
            this.Controls.Add(this.cb_aroma);
            this.Controls.Add(this.cb_liquid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nikotingehalt);
            this.Controls.Add(this.lb_pro);
            this.Controls.Add(this.lb_ml4);
            this.Controls.Add(this.lb_ml3);
            this.Controls.Add(this.lb_ml2);
            this.Controls.Add(this.lb_ml1);
            this.Controls.Add(this.cb_nikotin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_prozent);
            this.Controls.Add(this.lb_base);
            this.Controls.Add(this.lb_aroma);
            this.Controls.Add(this.lb_gesamtmenge);
            this.Controls.Add(this.tb_nikotin);
            this.Controls.Add(this.tb_prozent);
            this.Controls.Add(this.tb_base);
            this.Controls.Add(this.tb_aroma);
            this.Controls.Add(this.tb_gesamtmenge);
            this.Controls.Add(this.btn_berechnen);
            this.Name = "Form1";
            this.Text = "Liquido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_gesamtmenge;
        private System.Windows.Forms.TextBox tb_aroma;
        private System.Windows.Forms.TextBox tb_base;
        private System.Windows.Forms.TextBox tb_prozent;
        private System.Windows.Forms.Label lb_gesamtmenge;
        private System.Windows.Forms.Label lb_aroma;
        private System.Windows.Forms.Label lb_base;
        private System.Windows.Forms.Label lb_prozent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nikotin;
        private System.Windows.Forms.Label lb_ml1;
        private System.Windows.Forms.Label lb_ml2;
        private System.Windows.Forms.Label lb_ml3;
        private System.Windows.Forms.Label lb_ml4;
        private System.Windows.Forms.Label lb_pro;
        private System.Windows.Forms.CheckBox cb_nikotin;
        private System.Windows.Forms.Button btn_berechnen;
        private System.Windows.Forms.TextBox tb_nikotingehalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_liquid;
        private System.Windows.Forms.CheckBox cb_aroma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nikotinshot;
        private System.Windows.Forms.RichTextBox tb_kommentar;
        private System.Windows.Forms.TextBox tb_namearoma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_speichern;
    }
}

