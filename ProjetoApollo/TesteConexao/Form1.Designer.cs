﻿namespace TesteConexao
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
            this.buttonTestarConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTestarConexao
            // 
            this.buttonTestarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestarConexao.Location = new System.Drawing.Point(44, 99);
            this.buttonTestarConexao.Name = "buttonTestarConexao";
            this.buttonTestarConexao.Size = new System.Drawing.Size(192, 54);
            this.buttonTestarConexao.TabIndex = 0;
            this.buttonTestarConexao.Text = "Testar Conexao";
            this.buttonTestarConexao.UseVisualStyleBackColor = true;
            this.buttonTestarConexao.Click += new System.EventHandler(this.buttonTestarConexao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonTestarConexao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestarConexao;
    }
}

