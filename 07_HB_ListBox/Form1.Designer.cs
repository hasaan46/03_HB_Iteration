
namespace _07_HB_ListBox
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
            this.lstGerichte = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblAusgewählt = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGerichte
            // 
            this.lstGerichte.FormattingEnabled = true;
            this.lstGerichte.Location = new System.Drawing.Point(12, 12);
            this.lstGerichte.Name = "lstGerichte";
            this.lstGerichte.Size = new System.Drawing.Size(136, 147);
            this.lstGerichte.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(223, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Anzeigen";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(12, 189);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(10, 13);
            this.lblAnzahl.TabIndex = 2;
            this.lblAnzahl.Text = "-";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(12, 242);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(10, 13);
            this.lblIndex.TabIndex = 3;
            this.lblIndex.Text = "-";
            // 
            // lblAusgewählt
            // 
            this.lblAusgewählt.AutoSize = true;
            this.lblAusgewählt.Location = new System.Drawing.Point(12, 214);
            this.lblAusgewählt.Name = "lblAusgewählt";
            this.lblAusgewählt.Size = new System.Drawing.Size(10, 13);
            this.lblAusgewählt.TabIndex = 4;
            this.lblAusgewählt.Text = "-";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(12, 266);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(10, 13);
            this.lblAll.TabIndex = 5;
            this.lblAll.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 367);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblAusgewählt);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstGerichte);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Listenfeld-Eigenschaften";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGerichte;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblAusgewählt;
        private System.Windows.Forms.Label lblAll;
    }
}

