namespace ClienteForms
{
    partial class FormAgendamento
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.txtIDSala = new System.Windows.Forms.TextBox();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtIDHorario = new System.Windows.Forms.TextBox();
            this.comboBoxHorario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorSala = new System.Windows.Forms.TextBox();
            this.ValorTotal = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.radioBtnInstrumentoSim = new System.Windows.Forms.RadioButton();
            this.radioBtnInstrumentoNao = new System.Windows.Forms.RadioButton();
            this.comboBoxListaInstrumento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorInstrumento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVO AGENDAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(409, 115);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(204, 26);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecionar Cliente";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(43, 113);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(259, 28);
            this.comboBoxClientes.TabIndex = 4;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(324, 115);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(66, 26);
            this.txtIDCliente.TabIndex = 6;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ClienteForms.localhost.Cliente);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(ClienteForms.localhost.Cliente);
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataSource = typeof(ClienteForms.localhost.Cliente);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecionar Sala";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sala";
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(43, 180);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(259, 28);
            this.comboBoxSalas.TabIndex = 10;
            this.comboBoxSalas.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalas_SelectedIndexChanged);
            // 
            // txtIDSala
            // 
            this.txtIDSala.Enabled = false;
            this.txtIDSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSala.Location = new System.Drawing.Point(324, 182);
            this.txtIDSala.Name = "txtIDSala";
            this.txtIDSala.Size = new System.Drawing.Size(66, 26);
            this.txtIDSala.TabIndex = 11;
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSala.Location = new System.Drawing.Point(409, 182);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(204, 26);
            this.txtNomeSala.TabIndex = 12;
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(409, 255);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(204, 26);
            this.txtHorario.TabIndex = 18;
            // 
            // txtIDHorario
            // 
            this.txtIDHorario.Enabled = false;
            this.txtIDHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHorario.Location = new System.Drawing.Point(324, 257);
            this.txtIDHorario.Name = "txtIDHorario";
            this.txtIDHorario.Size = new System.Drawing.Size(66, 26);
            this.txtIDHorario.TabIndex = 17;
            // 
            // comboBoxHorario
            // 
            this.comboBoxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHorario.FormattingEnabled = true;
            this.comboBoxHorario.Location = new System.Drawing.Point(43, 255);
            this.comboBoxHorario.Name = "comboBoxHorario";
            this.comboBoxHorario.Size = new System.Drawing.Size(259, 28);
            this.comboBoxHorario.TabIndex = 16;
            this.comboBoxHorario.SelectedIndexChanged += new System.EventHandler(this.comboBoxHorario_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Selecionar Horário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(406, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Horário Início/Fim";
            // 
            // txtValorSala
            // 
            this.txtValorSala.Location = new System.Drawing.Point(619, 182);
            this.txtValorSala.Multiline = true;
            this.txtValorSala.Name = "txtValorSala";
            this.txtValorSala.Size = new System.Drawing.Size(71, 26);
            this.txtValorSala.TabIndex = 19;
            this.txtValorSala.TextChanged += new System.EventHandler(this.txtValorSala_TextChanged);
            // 
            // ValorTotal
            // 
            this.ValorTotal.Location = new System.Drawing.Point(619, 377);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(80, 20);
            this.ValorTotal.TabIndex = 20;
            this.ValorTotal.TextChanged += new System.EventHandler(this.ValorTotal_TextChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(616, 159);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(40, 18);
            this.l.TabIndex = 21;
            this.l.Text = "Valor";
            // 
            // radioBtnInstrumentoSim
            // 
            this.radioBtnInstrumentoSim.AutoSize = true;
            this.radioBtnInstrumentoSim.Location = new System.Drawing.Point(708, 72);
            this.radioBtnInstrumentoSim.Name = "radioBtnInstrumentoSim";
            this.radioBtnInstrumentoSim.Size = new System.Drawing.Size(42, 17);
            this.radioBtnInstrumentoSim.TabIndex = 22;
            this.radioBtnInstrumentoSim.TabStop = true;
            this.radioBtnInstrumentoSim.Text = "Sim";
            this.radioBtnInstrumentoSim.UseVisualStyleBackColor = true;
            this.radioBtnInstrumentoSim.CheckedChanged += new System.EventHandler(this.radioBtnInstrumentoSim_CheckedChanged);
            // 
            // radioBtnInstrumentoNao
            // 
            this.radioBtnInstrumentoNao.AutoSize = true;
            this.radioBtnInstrumentoNao.Location = new System.Drawing.Point(708, 95);
            this.radioBtnInstrumentoNao.Name = "radioBtnInstrumentoNao";
            this.radioBtnInstrumentoNao.Size = new System.Drawing.Size(45, 17);
            this.radioBtnInstrumentoNao.TabIndex = 23;
            this.radioBtnInstrumentoNao.TabStop = true;
            this.radioBtnInstrumentoNao.Text = "Nao";
            this.radioBtnInstrumentoNao.UseVisualStyleBackColor = true;
            this.radioBtnInstrumentoNao.CheckedChanged += new System.EventHandler(this.radioBtnInstrumentoNao_CheckedChanged);
            // 
            // comboBoxListaInstrumento
            // 
            this.comboBoxListaInstrumento.Enabled = false;
            this.comboBoxListaInstrumento.FormattingEnabled = true;
            this.comboBoxListaInstrumento.Location = new System.Drawing.Point(708, 118);
            this.comboBoxListaInstrumento.Name = "comboBoxListaInstrumento";
            this.comboBoxListaInstrumento.Size = new System.Drawing.Size(138, 21);
            this.comboBoxListaInstrumento.TabIndex = 24;
            this.comboBoxListaInstrumento.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaInstrumento_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(705, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Alugar Instrumento?";
            // 
            // txtValorInstrumento
            // 
            this.txtValorInstrumento.Enabled = false;
            this.txtValorInstrumento.Location = new System.Drawing.Point(867, 118);
            this.txtValorInstrumento.Multiline = true;
            this.txtValorInstrumento.Name = "txtValorInstrumento";
            this.txtValorInstrumento.Size = new System.Drawing.Size(100, 23);
            this.txtValorInstrumento.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(864, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(973, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(616, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Valor Total:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(619, 425);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(99, 30);
            this.btnCadastrar.TabIndex = 31;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(207, 301);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimento.TabIndex = 32;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(207, 327);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(100, 20);
            this.txtPagamento.TabIndex = 33;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(207, 353);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(100, 20);
            this.t.TabIndex = 34;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(44, 300);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(141, 18);
            this.a.TabIndex = 35;
            this.a.Text = "Data de Vencimento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "Data de Pagamento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 18);
            this.label15.TabIndex = 37;
            this.label15.Text = "Data de Cancelamento";
            // 
            // FormAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.a);
            this.Controls.Add(this.t);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValorInstrumento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxListaInstrumento);
            this.Controls.Add(this.radioBtnInstrumentoNao);
            this.Controls.Add(this.radioBtnInstrumentoSim);
            this.Controls.Add(this.l);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.txtValorSala);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtIDHorario);
            this.Controls.Add(this.comboBoxHorario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeSala);
            this.Controls.Add(this.txtIDSala);
            this.Controls.Add(this.comboBoxSalas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgendamento";
            this.Text = "FormAgendamento";
            this.Load += new System.EventHandler(this.FormAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.TextBox txtIDSala;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtIDHorario;
        private System.Windows.Forms.ComboBox comboBoxHorario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ValorTotal;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.RadioButton radioBtnInstrumentoSim;
        private System.Windows.Forms.RadioButton radioBtnInstrumentoNao;
        private System.Windows.Forms.ComboBox comboBoxListaInstrumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtValorSala;
        public System.Windows.Forms.TextBox txtValorInstrumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}