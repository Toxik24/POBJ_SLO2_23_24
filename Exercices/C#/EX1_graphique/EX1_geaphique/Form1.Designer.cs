namespace EX1_geaphique
{
    partial class windows_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbnSFR = new System.Windows.Forms.RadioButton();
            this.rbnUSD = new System.Windows.Forms.RadioButton();
            this.rbnGBP = new System.Windows.Forms.RadioButton();
            this.rbnYEN = new System.Windows.Forms.RadioButton();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicDevise = new System.Windows.Forms.PictureBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicDevise)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnSFR
            // 
            this.rbnSFR.AutoSize = true;
            this.rbnSFR.Location = new System.Drawing.Point(92, 24);
            this.rbnSFR.Name = "rbnSFR";
            this.rbnSFR.Size = new System.Drawing.Size(94, 19);
            this.rbnSFR.TabIndex = 0;
            this.rbnSFR.TabStop = true;
            this.rbnSFR.Text = "Francs Suisse";
            this.rbnSFR.UseVisualStyleBackColor = true;
            this.rbnSFR.CheckedChanged += new System.EventHandler(this.rbnSFR_CheckedChanged);
            // 
            // rbnUSD
            // 
            this.rbnUSD.AutoSize = true;
            this.rbnUSD.Location = new System.Drawing.Point(92, 74);
            this.rbnUSD.Name = "rbnUSD";
            this.rbnUSD.Size = new System.Drawing.Size(78, 19);
            this.rbnUSD.TabIndex = 1;
            this.rbnUSD.TabStop = true;
            this.rbnUSD.Text = "US Dollars";
            this.rbnUSD.UseVisualStyleBackColor = true;
            this.rbnUSD.CheckedChanged += new System.EventHandler(this.rbnUSD_CheckedChanged);
            // 
            // rbnGBP
            // 
            this.rbnGBP.AutoSize = true;
            this.rbnGBP.Location = new System.Drawing.Point(92, 126);
            this.rbnGBP.Name = "rbnGBP";
            this.rbnGBP.Size = new System.Drawing.Size(98, 19);
            this.rbnGBP.TabIndex = 2;
            this.rbnGBP.TabStop = true;
            this.rbnGBP.Text = "Livres Sterling";
            this.rbnGBP.UseVisualStyleBackColor = true;
            this.rbnGBP.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbnYEN
            // 
            this.rbnYEN.AutoSize = true;
            this.rbnYEN.Location = new System.Drawing.Point(92, 172);
            this.rbnYEN.Name = "rbnYEN";
            this.rbnYEN.Size = new System.Drawing.Size(92, 19);
            this.rbnYEN.TabIndex = 3;
            this.rbnYEN.TabStop = true;
            this.rbnYEN.Text = "Yen Japonais";
            this.rbnYEN.UseVisualStyleBackColor = true;
            this.rbnYEN.CheckedChanged += new System.EventHandler(this.rbnYEN_CheckedChanged);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(69, 268);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(152, 23);
            this.txtMontant.TabIndex = 4;
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(399, 268);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(152, 23);
            this.txtResultat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultat en Euro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montant";
            // 
            // PicDevise
            // 
            this.PicDevise.Image = global::EX1_geaphique.Properties.Resources.flag_US;
            this.PicDevise.Location = new System.Drawing.Point(257, 24);
            this.PicDevise.Name = "PicDevise";
            this.PicDevise.Size = new System.Drawing.Size(221, 182);
            this.PicDevise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDevise.TabIndex = 8;
            this.PicDevise.TabStop = false;
            this.PicDevise.Click += new System.EventHandler(this.PicDevise_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(245, 252);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(127, 52);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // windows_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 360);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.PicDevise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.rbnYEN);
            this.Controls.Add(this.rbnGBP);
            this.Controls.Add(this.rbnUSD);
            this.Controls.Add(this.rbnSFR);
            this.Name = "windows_1";
            this.Text = "EX1 C# Convertisseur de devises en euro S.Pitton";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicDevise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbnSFR;
        private RadioButton rbnUSD;
        private RadioButton rbnGBP;
        private RadioButton rbnYEN;
        private TextBox txtMontant;
        private TextBox txtResultat;
        private Label label1;
        private Label label2;
        private PictureBox PicDevise;
        private Button btnConvertir;
    }
}