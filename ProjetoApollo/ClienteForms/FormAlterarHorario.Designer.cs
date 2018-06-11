namespace ClienteForms
{
    partial class FormAlterarHorario
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
            this.btnCancelarCadastrarHorario = new System.Windows.Forms.Button();
            this.btnAtualizarHorario = new System.Windows.Forms.Button();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCadastrarHorario
            // 
            this.btnCancelarCadastrarHorario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastrarHorario.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastrarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastrarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastrarHorario.Location = new System.Drawing.Point(193, 256);
            this.btnCancelarCadastrarHorario.Name = "btnCancelarCadastrarHorario";
            this.btnCancelarCadastrarHorario.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarCadastrarHorario.TabIndex = 27;
            this.btnCancelarCadastrarHorario.Text = "Cancelar";
            this.btnCancelarCadastrarHorario.UseVisualStyleBackColor = false;
            this.btnCancelarCadastrarHorario.Click += new System.EventHandler(this.btnCancelarCadastrarHorario_Click);
            // 
            // btnAtualizarHorario
            // 
            this.btnAtualizarHorario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtualizarHorario.FlatAppearance.BorderSize = 0;
            this.btnAtualizarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarHorario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAtualizarHorario.Location = new System.Drawing.Point(321, 257);
            this.btnAtualizarHorario.Name = "btnAtualizarHorario";
            this.btnAtualizarHorario.Size = new System.Drawing.Size(170, 35);
            this.btnAtualizarHorario.TabIndex = 26;
            this.btnAtualizarHorario.Text = "Atualizar";
            this.btnAtualizarHorario.UseVisualStyleBackColor = false;
            this.btnAtualizarHorario.Click += new System.EventHandler(this.btnAtualizarHorario_Click);
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFinal.Location = new System.Drawing.Point(287, 193);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(204, 26);
            this.txtHoraFinal.TabIndex = 25;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(43, 193);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(204, 26);
            this.txtHoraInicio.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Horário Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Horário Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "ALTERAR HORÁRIO";
            // 
            // txtHoraID
            // 
            this.txtHoraID.Enabled = false;
            this.txtHoraID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraID.Location = new System.Drawing.Point(43, 123);
            this.txtHoraID.Name = "txtHoraID";
            this.txtHoraID.Size = new System.Drawing.Size(98, 26);
            this.txtHoraID.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // FormAlterarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(544, 331);
            this.Controls.Add(this.txtHoraID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarCadastrarHorario);
            this.Controls.Add(this.btnAtualizarHorario);
            this.Controls.Add(this.txtHoraFinal);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FormAlterarHorario";
            this.Text = "FormAlterarHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCadastrarHorario;
        private System.Windows.Forms.Button btnAtualizarHorario;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraID;
        private System.Windows.Forms.Label label3;
    }
}