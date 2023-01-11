
namespace _08_HB_SelctedIndexChanged
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAusgewählt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstGerichte
            // 
            this.lstGerichte.FormattingEnabled = true;
            this.lstGerichte.Location = new System.Drawing.Point(12, 12);
            this.lstGerichte.Name = "lstGerichte";
            this.lstGerichte.Size = new System.Drawing.Size(317, 160);
            this.lstGerichte.TabIndex = 0;
            this.lstGerichte.SelectedIndexChanged += new System.EventHandler(this.lstGerichte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ausgewählt: ";
            // 
            // txtBoxAusgewählt
            // 
            this.txtBoxAusgewählt.Location = new System.Drawing.Point(86, 209);
            this.txtBoxAusgewählt.Name = "txtBoxAusgewählt";
            this.txtBoxAusgewählt.ReadOnly = true;
            this.txtBoxAusgewählt.Size = new System.Drawing.Size(243, 20);
            this.txtBoxAusgewählt.TabIndex = 2;
            this.txtBoxAusgewählt.TextChanged += new System.EventHandler(this.txtBoxAusgewählt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 279);
            this.Controls.Add(this.txtBoxAusgewählt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGerichte);
            this.Name = "Form1";
            this.Text = "Listenfeld-Ereignis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGerichte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAusgewählt;
    }
}

