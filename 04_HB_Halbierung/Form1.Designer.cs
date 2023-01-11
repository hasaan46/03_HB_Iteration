
namespace _04_HB_Halbierung
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
            this.txtZahleingabe = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblZahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZahleingabe
            // 
            this.txtZahleingabe.Location = new System.Drawing.Point(12, 12);
            this.txtZahleingabe.Name = "txtZahleingabe";
            this.txtZahleingabe.Size = new System.Drawing.Size(100, 20);
            this.txtZahleingabe.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 49);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Anzeigen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblZahl
            // 
            this.lblZahl.AutoSize = true;
            this.lblZahl.Location = new System.Drawing.Point(162, 15);
            this.lblZahl.Name = "lblZahl";
            this.lblZahl.Size = new System.Drawing.Size(0, 13);
            this.lblZahl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 337);
            this.Controls.Add(this.lblZahl);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtZahleingabe);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Halbierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZahleingabe;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblZahl;
    }
}

