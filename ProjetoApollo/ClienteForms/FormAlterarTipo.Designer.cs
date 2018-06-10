namespace ClienteForms
{
    partial class FormAlterarTipo
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
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarAtualizarTipo = new System.Windows.Forms.Button();
            this.btnAtualizarTipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALTERAR TIPO";
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTipo.Location = new System.Drawing.Point(43, 192);
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(773, 26);
            this.txtNomeTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtIDTipo
            // 
            this.txtIDTipo.Enabled = false;
            this.txtIDTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTipo.Location = new System.Drawing.Point(43, 120);
            this.txtIDTipo.Name = "txtIDTipo";
            this.txtIDTipo.Size = new System.Drawing.Size(94, 26);
            this.txtIDTipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // btnCancelarAtualizarTipo
            // 
            this.btnCancelarAtualizarTipo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarAtualizarTipo.FlatAppearance.BorderSize = 0;
            this.btnCancelarAtualizarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAtualizarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAtualizarTipo.Location = new System.Drawing.Point(517, 263);
            this.btnCancelarAtualizarTipo.Name = "btnCancelarAtualizarTipo";
            this.btnCancelarAtualizarTipo.Size = new System.Drawing.Size(100, 35);
            this.btnCancelarAtualizarTipo.TabIndex = 8;
            this.btnCancelarAtualizarTipo.Text = "Cancelar";
            this.btnCancelarAtualizarTipo.UseVisualStyleBackColor = false;
            this.btnCancelarAtualizarTipo.Click += new System.EventHandler(this.btnCancelarAtualizarTipo_Click);
            // 
            // btnAtualizarTipo
            // 
            this.btnAtualizarTipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtualizarTipo.FlatAppearance.BorderSize = 0;
            this.btnAtualizarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAtualizarTipo.Location = new System.Drawing.Point(646, 261);
            this.btnAtualizarTipo.Name = "btnAtualizarTipo";
            this.btnAtualizarTipo.Size = new System.Drawing.Size(170, 36);
            this.btnAtualizarTipo.TabIndex = 7;
            this.btnAtualizarTipo.Text = "Atualizar";
            this.btnAtualizarTipo.UseVisualStyleBackColor = false;
            this.btnAtualizarTipo.Click += new System.EventHandler(this.btnAtualizarTipo_Click);
            // 
            // FormAlterarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 341);
            this.Controls.Add(this.btnCancelarAtualizarTipo);
            this.Controls.Add(this.btnAtualizarTipo);
            this.Controls.Add(this.txtIDTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterarTipo";
            this.Text = "FormAlterarTipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarAtualizarTipo;
        private System.Windows.Forms.Button btnAtualizarTipo;
    }
}