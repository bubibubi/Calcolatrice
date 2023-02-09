namespace Calcolatrice
{
    partial class Form1
    {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPiu = new System.Windows.Forms.Button();
            this.btnDiviso = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.lstRisultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnPiu
            // 
            this.btnPiu.Location = new System.Drawing.Point(48, 118);
            this.btnPiu.Name = "btnPiu";
            this.btnPiu.Size = new System.Drawing.Size(44, 23);
            this.btnPiu.TabIndex = 2;
            this.btnPiu.Text = "+";
            this.btnPiu.UseVisualStyleBackColor = true;
            this.btnPiu.Click += new System.EventHandler(this.btnPiu_Click);
            // 
            // btnDiviso
            // 
            this.btnDiviso.Location = new System.Drawing.Point(198, 118);
            this.btnDiviso.Name = "btnDiviso";
            this.btnDiviso.Size = new System.Drawing.Size(44, 23);
            this.btnDiviso.TabIndex = 4;
            this.btnDiviso.Text = "/";
            this.btnDiviso.UseVisualStyleBackColor = true;
            this.btnDiviso.Click += new System.EventHandler(this.btnDiviso_Click);
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(148, 118);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(44, 23);
            this.btnPer.TabIndex = 5;
            this.btnPer.Text = "x";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Location = new System.Drawing.Point(98, 118);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(44, 23);
            this.btnMeno.TabIndex = 6;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // lstRisultati
            // 
            this.lstRisultati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRisultati.FormattingEnabled = true;
            this.lstRisultati.ItemHeight = 16;
            this.lstRisultati.Location = new System.Drawing.Point(277, 12);
            this.lstRisultati.Name = "lstRisultati";
            this.lstRisultati.Size = new System.Drawing.Size(381, 292);
            this.lstRisultati.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 321);
            this.Controls.Add(this.lstRisultati);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnDiviso);
            this.Controls.Add(this.btnPiu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPiu;
        private System.Windows.Forms.Button btnDiviso;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.ListBox lstRisultati;
    }
}

