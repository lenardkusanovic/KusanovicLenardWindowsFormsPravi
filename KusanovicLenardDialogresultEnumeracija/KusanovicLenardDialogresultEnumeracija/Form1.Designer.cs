﻿namespace KusanovicLenardDialogresultEnumeracija
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
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(72, 100);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(157, 96);
            this.textBoxRezultat.TabIndex = 0;
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.textBoxRezultat_TextChanged);
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(85, 41);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(127, 23);
            this.buttonOtvori.TabIndex = 1;
            this.buttonOtvori.Text = "Otvorite MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 239);
            this.Controls.Add(this.buttonOtvori);
            this.Controls.Add(this.textBoxRezultat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonOtvori;
    }
}

