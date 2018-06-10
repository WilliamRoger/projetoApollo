namespace ClienteForms
{
    partial class FormCadastrarTipo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.btnCadastrarTipo = new System.Windows.Forms.Button();
            this.btnCancelarCadastrarTipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTipo.Location = new System.Drawing.Point(48, 125);
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(773, 26);
            this.txtNomeTipo.TabIndex = 2;
            // 
            // btnCadastrarTipo
            // 
            this.btnCadastrarTipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarTipo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrarTipo.Location = new System.Drawing.Point(651, 193);
            this.btnCadastrarTipo.Name = "btnCadastrarTipo";
            this.btnCadastrarTipo.Size = new System.Drawing.Size(170, 36);
            this.btnCadastrarTipo.TabIndex = 3;
            this.btnCadastrarTipo.Text = "Cadastrar";
            this.btnCadastrarTipo.UseVisualStyleBackColor = false;
            this.btnCadastrarTipo.Click += new System.EventHandler(this.btnCadastrarTipo_Click);
            // 
            // btnCancelarCadastrarTipo
            // 
            this.btnCancelarCadastrarTipo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastrarTipo.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastrarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastrarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastrarTipo.Location = new System.Drawing.Point(522, 195);
            this.btnCancelarCadastrarTipo.Name = "btnCancelarCadastrarTipo";
            this.btnCancelarCadastrarTipo.Size = new System.Drawing.Size(100, 35);
            this.btnCancelarCadastrarTipo.TabIndex = 4;
            this.btnCancelarCadastrarTipo.Text = "Cancelar";
            this.btnCancelarCadastrarTipo.UseVisualStyleBackColor = false;
            this.btnCancelarCadastrarTipo.Click += new System.EventHandler(this.btnCancelarCadastrarTipo_Click);
            // 
            // FormCadastrarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.btnCancelarCadastrarTipo);
            this.Controls.Add(this.btnCadastrarTipo);
            this.Controls.Add(this.txtNomeTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastrarTipo";
            this.Text = "FormCadastrarTipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTipo;
        private System.Windows.Forms.Button btnCadastrarTipo;
        private System.Windows.Forms.Button btnCancelarCadastrarTipo;
    }
}