namespace ClienteForms
{
    partial class FormCadastrarHorario
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorarioInicio = new System.Windows.Forms.TextBox();
            this.txtHorarioFim = new System.Windows.Forms.TextBox();
            this.btnCancelarCadastrarHorario = new System.Windows.Forms.Button();
            this.btnCadastrarHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "NOVO HORÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Horário Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Horário Fim";
            // 
            // txtHorarioInicio
            // 
            this.txtHorarioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarioInicio.Location = new System.Drawing.Point(43, 125);
            this.txtHorarioInicio.Name = "txtHorarioInicio";
            this.txtHorarioInicio.Size = new System.Drawing.Size(204, 26);
            this.txtHorarioInicio.TabIndex = 17;
            // 
            // txtHorarioFim
            // 
            this.txtHorarioFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarioFim.Location = new System.Drawing.Point(287, 125);
            this.txtHorarioFim.Name = "txtHorarioFim";
            this.txtHorarioFim.Size = new System.Drawing.Size(204, 26);
            this.txtHorarioFim.TabIndex = 18;
            // 
            // btnCancelarCadastrarHorario
            // 
            this.btnCancelarCadastrarHorario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastrarHorario.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastrarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastrarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastrarHorario.Location = new System.Drawing.Point(193, 193);
            this.btnCancelarCadastrarHorario.Name = "btnCancelarCadastrarHorario";
            this.btnCancelarCadastrarHorario.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarCadastrarHorario.TabIndex = 20;
            this.btnCancelarCadastrarHorario.Text = "Cancelar";
            this.btnCancelarCadastrarHorario.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarHorario
            // 
            this.btnCadastrarHorario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarHorario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarHorario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrarHorario.Location = new System.Drawing.Point(321, 194);
            this.btnCadastrarHorario.Name = "btnCadastrarHorario";
            this.btnCadastrarHorario.Size = new System.Drawing.Size(170, 35);
            this.btnCadastrarHorario.TabIndex = 19;
            this.btnCadastrarHorario.Text = "Cadastrar";
            this.btnCadastrarHorario.UseVisualStyleBackColor = false;
            this.btnCadastrarHorario.Click += new System.EventHandler(this.btnCadastrarHorario_Click);
            // 
            // FormCadastrarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(544, 271);
            this.Controls.Add(this.btnCancelarCadastrarHorario);
            this.Controls.Add(this.btnCadastrarHorario);
            this.Controls.Add(this.txtHorarioFim);
            this.Controls.Add(this.txtHorarioInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FormCadastrarHorario";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorarioInicio;
        private System.Windows.Forms.TextBox txtHorarioFim;
        private System.Windows.Forms.Button btnCancelarCadastrarHorario;
        private System.Windows.Forms.Button btnCadastrarHorario;
    }
}