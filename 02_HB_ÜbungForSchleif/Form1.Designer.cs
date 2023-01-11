
namespace _02_HB_ÜbungForSchleif
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rTxtZahl1 = new System.Windows.Forms.RichTextBox();
            this.txtSumme = new System.Windows.Forms.TextBox();
            this.txtMittelwert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ausgabe der Zahlen zwischen 35 und 20 in absteigendend 2,5er Schritten\r\n";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(119, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 38);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Ausgabe";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rTxtZahl1
            // 
            this.rTxtZahl1.Location = new System.Drawing.Point(15, 81);
            this.rTxtZahl1.Name = "rTxtZahl1";
            this.rTxtZahl1.ReadOnly = true;
            this.rTxtZahl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rTxtZahl1.Size = new System.Drawing.Size(100, 141);
            this.rTxtZahl1.TabIndex = 4;
            this.rTxtZahl1.Text = "";
            // 
            // txtSumme
            // 
            this.txtSumme.Location = new System.Drawing.Point(15, 255);
            this.txtSumme.Name = "txtSumme";
            this.txtSumme.ReadOnly = true;
            this.txtSumme.Size = new System.Drawing.Size(100, 20);
            this.txtSumme.TabIndex = 5;
            this.txtSumme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMittelwert
            // 
            this.txtMittelwert.Location = new System.Drawing.Point(15, 281);
            this.txtMittelwert.Name = "txtMittelwert";
            this.txtMittelwert.ReadOnly = true;
            this.txtMittelwert.Size = new System.Drawing.Size(100, 20);
            this.txtMittelwert.TabIndex = 6;
            this.txtMittelwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 334);
            this.Controls.Add(this.txtMittelwert);
            this.Controls.Add(this.txtSumme);
            this.Controls.Add(this.rTxtZahl1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "02 Übung - For-schleife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rTxtZahl1;
        private System.Windows.Forms.TextBox txtSumme;
        private System.Windows.Forms.TextBox txtMittelwert;
    }
}

