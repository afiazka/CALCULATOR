namespace CalculatorWindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.nilaiA = new System.Windows.Forms.TextBox();
            this.nilaiB = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "PENJUMLAHAN",
            "PENGURANGAN",
            "PERKALIAN",
            "PEMBAGIAN"});
            this.comboBox.Location = new System.Drawing.Point(113, 27);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(264, 24);
            this.comboBox.TabIndex = 5;
            // 
            // nilaiA
            // 
            this.nilaiA.Location = new System.Drawing.Point(113, 71);
            this.nilaiA.Name = "nilaiA";
            this.nilaiA.Size = new System.Drawing.Size(263, 22);
            this.nilaiA.TabIndex = 6;
            // 
            // nilaiB
            // 
            this.nilaiB.Location = new System.Drawing.Point(113, 116);
            this.nilaiB.Name = "nilaiB";
            this.nilaiB.Size = new System.Drawing.Size(263, 22);
            this.nilaiB.TabIndex = 7;
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(113, 170);
            this.hasil.Name = "hasil";
            this.hasil.ReadOnly = true;
            this.hasil.ShortcutsEnabled = false;
            this.hasil.Size = new System.Drawing.Size(262, 22);
            this.hasil.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nila A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "HASILNYA";
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(23, 227);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(351, 67);
            this.hitung.TabIndex = 13;
            this.hitung.Text = "HITUNG";
            this.hitung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.nilaiB);
            this.Controls.Add(this.nilaiA);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox nilaiA;
        private System.Windows.Forms.TextBox nilaiB;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hitung;
    }
}

