namespace DatumJatek {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbSzuletesiDatum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKor = new System.Windows.Forms.TextBox();
            this.tbSzuletesiNap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tbKesobbiNap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNapSorszam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNapSzam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblUzenet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos idő és dátum";
            //
            // lblIdo
            //
            this.lblIdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdo.Location = new System.Drawing.Point(179, 19);
            this.lblIdo.Name = "lblIdo";
            this.lblIdo.Size = new System.Drawing.Size(346, 39);
            this.lblIdo.TabIndex = 1;
            this.lblIdo.Text = "lblIdo";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Születési dátum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // mtbSzuletesiDatum
            //
            this.mtbSzuletesiDatum.Location = new System.Drawing.Point(136, 93);
            this.mtbSzuletesiDatum.Mask = "0000-00-00";
            this.mtbSzuletesiDatum.Name = "mtbSzuletesiDatum";
            this.mtbSzuletesiDatum.Size = new System.Drawing.Size(90, 20);
            this.mtbSzuletesiDatum.TabIndex = 3;
            this.mtbSzuletesiDatum.Leave += new System.EventHandler(this.mtbSzuletesiDatum_Leave);
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ennyi éves vagy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tbKor
            //
            this.tbKor.Location = new System.Drawing.Point(136, 134);
            this.tbKor.Name = "tbKor";
            this.tbKor.ReadOnly = true;
            this.tbKor.Size = new System.Drawing.Size(90, 20);
            this.tbKor.TabIndex = 5;
            //
            // tbSzuletesiNap
            //
            this.tbSzuletesiNap.Location = new System.Drawing.Point(387, 136);
            this.tbSzuletesiNap.Name = "tbSzuletesiNap";
            this.tbSzuletesiNap.ReadOnly = true;
            this.tbSzuletesiNap.Size = new System.Drawing.Size(120, 20);
            this.tbSzuletesiNap.TabIndex = 7;
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(261, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ilyen napon születtél";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label5
            //
            this.label5.Location = new System.Drawing.Point(26, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tetszőleges dátum";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // datePicker
            //
            this.datePicker.Location = new System.Drawing.Point(26, 268);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(131, 20);
            this.datePicker.TabIndex = 9;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            //
            // tbKesobbiNap
            //
            this.tbKesobbiNap.Location = new System.Drawing.Point(352, 271);
            this.tbKesobbiNap.Name = "tbKesobbiNap";
            this.tbKesobbiNap.ReadOnly = true;
            this.tbKesobbiNap.Size = new System.Drawing.Size(107, 20);
            this.tbKesobbiNap.TabIndex = 11;
            //
            // label6
            //
            this.label6.Location = new System.Drawing.Point(215, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "nappal későbbi dátum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tbNapSorszam
            //
            this.tbNapSorszam.Location = new System.Drawing.Point(352, 234);
            this.tbNapSorszam.Name = "tbNapSorszam";
            this.tbNapSorszam.ReadOnly = true;
            this.tbNapSorszam.Size = new System.Drawing.Size(37, 20);
            this.tbNapSorszam.TabIndex = 13;
            //
            // label7
            //
            this.label7.Location = new System.Drawing.Point(215, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ez az év ennyiedik napja";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tbNapSzam
            //
            this.tbNapSzam.Location = new System.Drawing.Point(190, 271);
            this.tbNapSzam.Name = "tbNapSzam";
            this.tbNapSzam.Size = new System.Drawing.Size(37, 20);
            this.tbNapSzam.TabIndex = 14;
            this.tbNapSzam.TextChanged += new System.EventHandler(this.tbNapSzam_TextChanged_1);
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(117, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kiír";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(233, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Töröl";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(342, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Bezár";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // lblUzenet
            //
            this.lblUzenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUzenet.ForeColor = System.Drawing.Color.Maroon;
            this.lblUzenet.Location = new System.Drawing.Point(63, 190);
            this.lblUzenet.Name = "lblUzenet";
            this.lblUzenet.Size = new System.Drawing.Size(444, 41);
            this.lblUzenet.TabIndex = 18;
            this.lblUzenet.Text = "label8";
            this.lblUzenet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // timer1
            //
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblUzenet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNapSzam);
            this.Controls.Add(this.tbNapSorszam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKesobbiNap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSzuletesiNap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbSzuletesiDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Label lblUzenet;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox tbNapSzam;

        private System.Windows.Forms.TextBox tbKesobbiNap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNapSorszam;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.DateTimePicker datePicker;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox tbSzuletesiNap;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKor;

        private System.Windows.Forms.MaskedTextBox mtbSzuletesiDatum;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblIdo;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}