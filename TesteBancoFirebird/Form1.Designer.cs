﻿namespace TesteBancoFirebird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.lblMensagem = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(4, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(784, 329);
      this.dataGridView1.TabIndex = 0;
      // 
      // lblMensagem
      // 
      this.lblMensagem.AutoSize = true;
      this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblMensagem.Location = new System.Drawing.Point(324, 373);
      this.lblMensagem.Name = "lblMensagem";
      this.lblMensagem.Size = new System.Drawing.Size(63, 25);
      this.lblMensagem.TabIndex = 1;
      this.lblMensagem.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblMensagem);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblMensagem;
    }
}