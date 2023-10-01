namespace ChekBox
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
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.sendbut = new System.Windows.Forms.Button();
            this.checkBoxSakrij = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(55, 56);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Dorucak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(55, 89);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Rucak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(55, 122);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Vecera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // sendbut
            // 
            this.sendbut.Location = new System.Drawing.Point(55, 168);
            this.sendbut.Name = "sendbut";
            this.sendbut.Size = new System.Drawing.Size(75, 23);
            this.sendbut.TabIndex = 3;
            this.sendbut.Text = "Posalji";
            this.sendbut.UseVisualStyleBackColor = true;
            this.sendbut.Click += new System.EventHandler(this.sendbut_Click);
            // 
            // checkBoxSakrij
            // 
            this.checkBoxSakrij.AutoSize = true;
            this.checkBoxSakrij.Location = new System.Drawing.Point(180, 172);
            this.checkBoxSakrij.Name = "checkBoxSakrij";
            this.checkBoxSakrij.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSakrij.TabIndex = 4;
            this.checkBoxSakrij.Text = "Sakrij narudžbu";
            this.checkBoxSakrij.UseVisualStyleBackColor = true;
            this.checkBoxSakrij.CheckedChanged += new System.EventHandler(this.checkBoxSakrij_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 85);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Odabrali ste:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 243);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxSakrij);
            this.Controls.Add(this.sendbut);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button sendbut;
        private System.Windows.Forms.CheckBox checkBoxSakrij;
        private System.Windows.Forms.TextBox textBox1;
    }
}

