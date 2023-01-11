
namespace _06_HB_Sparziel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnfangEuro = new System.Windows.Forms.TextBox();
            this.txtEndEuro = new System.Windows.Forms.TextBox();
            this.txtZinssatz = new System.Windows.Forms.TextBox();
            this.txtJahre = new System.Windows.Forms.TextBox();
            this.txtTatEndkapital = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anfangskapital in Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anlagedauer in Jahren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zinssatz in %:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gewünschtes Endkapital in Euro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endkapital in Euro:";
            // 
            // txtAnfangEuro
            // 
            this.txtAnfangEuro.Location = new System.Drawing.Point(263, 49);
            this.txtAnfangEuro.Name = "txtAnfangEuro";
            this.txtAnfangEuro.Size = new System.Drawing.Size(100, 20);
            this.txtAnfangEuro.TabIndex = 5;
            this.txtAnfangEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEndEuro
            // 
            this.txtEndEuro.Location = new System.Drawing.Point(263, 78);
            this.txtEndEuro.Name = "txtEndEuro";
            this.txtEndEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEndEuro.TabIndex = 6;
            this.txtEndEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZinssatz
            // 
            this.txtZinssatz.Location = new System.Drawing.Point(263, 104);
            this.txtZinssatz.Name = "txtZinssatz";
            this.txtZinssatz.Size = new System.Drawing.Size(100, 20);
            this.txtZinssatz.TabIndex = 7;
            this.txtZinssatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtJahre
            // 
            this.txtJahre.Location = new System.Drawing.Point(263, 133);
            this.txtJahre.Name = "txtJahre";
            this.txtJahre.ReadOnly = true;
            this.txtJahre.Size = new System.Drawing.Size(100, 20);
            this.txtJahre.TabIndex = 8;
            this.txtJahre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTatEndkapital
            // 
            this.txtTatEndkapital.Location = new System.Drawing.Point(263, 161);
            this.txtTatEndkapital.Name = "txtTatEndkapital";
            this.txtTatEndkapital.ReadOnly = true;
            this.txtTatEndkapital.Size = new System.Drawing.Size(100, 20);
            this.txtTatEndkapital.TabIndex = 9;
            this.txtTatEndkapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 250);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 43);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Rechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(160, 250);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 43);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Neue Eingabe";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 43);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 356);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTatEndkapital);
            this.Controls.Add(this.txtJahre);
            this.Controls.Add(this.txtZinssatz);
            this.Controls.Add(this.txtEndEuro);
            this.Controls.Add(this.txtAnfangEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ermittlung der Anlagedauer für ein bestimmtes Sparziel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnfangEuro;
        private System.Windows.Forms.TextBox txtEndEuro;
        private System.Windows.Forms.TextBox txtZinssatz;
        private System.Windows.Forms.TextBox txtJahre;
        private System.Windows.Forms.TextBox txtTatEndkapital;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
    }
}

