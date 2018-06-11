namespace ClienteForms
{
    partial class FormCadastrarSala
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorSala = new System.Windows.Forms.TextBox();
            this.txtDescricaoSala = new System.Windows.Forms.TextBox();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.btnCadastrarSala = new System.Windows.Forms.Button();
            this.btnCancelarCadastrarSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "NOVA SALA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descricao";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorSala
            // 
            this.txtValorSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSala.Location = new System.Drawing.Point(43, 374);
            this.txtValorSala.Name = "txtValorSala";
            this.txtValorSala.Size = new System.Drawing.Size(124, 26);
            this.txtValorSala.TabIndex = 18;
            this.txtValorSala.TextChanged += new System.EventHandler(this.txtEmailCliente_TextChanged);
            // 
            // txtDescricaoSala
            // 
            this.txtDescricaoSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoSala.Location = new System.Drawing.Point(43, 232);
            this.txtDescricaoSala.Multiline = true;
            this.txtDescricaoSala.Name = "txtDescricaoSala";
            this.txtDescricaoSala.Size = new System.Drawing.Size(468, 96);
            this.txtDescricaoSala.TabIndex = 17;
            this.txtDescricaoSala.TextChanged += new System.EventHandler(this.txtTelefoneCliente_TextChanged);
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSala.Location = new System.Drawing.Point(43, 161);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(468, 26);
            this.txtNomeSala.TabIndex = 16;
            this.txtNomeSala.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // btnCadastrarSala
            // 
            this.btnCadastrarSala.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarSala.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSala.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrarSala.Location = new System.Drawing.Point(381, 438);
            this.btnCadastrarSala.Name = "btnCadastrarSala";
            this.btnCadastrarSala.Size = new System.Drawing.Size(130, 35);
            this.btnCadastrarSala.TabIndex = 23;
            this.btnCadastrarSala.Text = "Cadastrar";
            this.btnCadastrarSala.UseVisualStyleBackColor = false;
            this.btnCadastrarSala.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarCadastrarSala
            // 
            this.btnCancelarCadastrarSala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastrarSala.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastrarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastrarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastrarSala.Location = new System.Drawing.Point(240, 438);
            this.btnCancelarCadastrarSala.Name = "btnCancelarCadastrarSala";
            this.btnCancelarCadastrarSala.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarCadastrarSala.TabIndex = 24;
            this.btnCancelarCadastrarSala.Text = "Cancelar";
            this.btnCancelarCadastrarSala.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(559, 521);
            this.Controls.Add(this.btnCancelarCadastrarSala);
            this.Controls.Add(this.btnCadastrarSala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorSala);
            this.Controls.Add(this.txtDescricaoSala);
            this.Controls.Add(this.txtNomeSala);
            this.Name = "FormCadastrarSala";
            this.Text = "FormCadastrarSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorSala;
        private System.Windows.Forms.TextBox txtDescricaoSala;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Button btnCadastrarSala;
        private System.Windows.Forms.Button btnCancelarCadastrarSala;
    }
}