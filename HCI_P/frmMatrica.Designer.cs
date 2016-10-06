namespace HCI_P {
    partial class frmMatrica {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrica));
            this.txtMatrica = new System.Windows.Forms.RichTextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatrica
            // 
            this.txtMatrica.Location = new System.Drawing.Point(0, 37);
            this.txtMatrica.Name = "txtMatrica";
            this.txtMatrica.Size = new System.Drawing.Size(895, 321);
            this.txtMatrica.TabIndex = 0;
            this.txtMatrica.Text = "";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("btnIzlaz.Image")));
            this.btnIzlaz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzlaz.Location = new System.Drawing.Point(400, 364);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(109, 24);
            this.btnIzlaz.TabIndex = 51;
            this.btnIzlaz.Text = "Nazad";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Matrica 120x120 [R,G,B]";
            // 
            // frmMatrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(895, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtMatrica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMatrica";
            this.Load += new System.EventHandler(this.frmMatrica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMatrica;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label1;
    }
}