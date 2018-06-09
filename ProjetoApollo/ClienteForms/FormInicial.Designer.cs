namespace ClienteForms
{
    partial class FormInicial
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovoAgendamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNovaSala = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnNovoHorario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnNovoArtista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnNovoInstrumento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnNovoTipo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Controls.Add(this.tabPage3);
            this.tabControlMenu.Controls.Add(this.tabPage4);
            this.tabControlMenu.Controls.Add(this.tabPage5);
            this.tabControlMenu.Controls.Add(this.tabPage6);
            this.tabControlMenu.Controls.Add(this.tabPage7);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1040, 657);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.btnNovoAgendamento);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agendamentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(18, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(997, 529);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cliente";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sala";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hora Início";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hora Fim";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Valor";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pagamento";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ações";
            this.columnHeader9.Width = 100;
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoAgendamento.FlatAppearance.BorderSize = 0;
            this.btnNovoAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAgendamento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgendamento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoAgendamento.Location = new System.Drawing.Point(845, 15);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new System.Drawing.Size(170, 40);
            this.btnNovoAgendamento.TabIndex = 1;
            this.btnNovoAgendamento.Text = "Novo Agendamento";
            this.btnNovoAgendamento.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDAMENTOS";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNovoCliente);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoCliente.Location = new System.Drawing.Point(845, 15);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(170, 40);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTES";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNovaSala);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1032, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNovaSala
            // 
            this.btnNovaSala.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovaSala.FlatAppearance.BorderSize = 0;
            this.btnNovaSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaSala.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaSala.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovaSala.Location = new System.Drawing.Point(845, 15);
            this.btnNovaSala.Name = "btnNovaSala";
            this.btnNovaSala.Size = new System.Drawing.Size(170, 40);
            this.btnNovaSala.TabIndex = 1;
            this.btnNovaSala.Text = "Nova Sala";
            this.btnNovaSala.UseVisualStyleBackColor = false;
            this.btnNovaSala.Click += new System.EventHandler(this.btnNovaSala_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "SALAS";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnNovoHorario);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1032, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Horários";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnNovoHorario
            // 
            this.btnNovoHorario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoHorario.FlatAppearance.BorderSize = 0;
            this.btnNovoHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoHorario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHorario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoHorario.Location = new System.Drawing.Point(845, 15);
            this.btnNovoHorario.Name = "btnNovoHorario";
            this.btnNovoHorario.Size = new System.Drawing.Size(170, 40);
            this.btnNovoHorario.TabIndex = 1;
            this.btnNovoHorario.Text = "Novo Horário";
            this.btnNovoHorario.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "HORÁRIOS";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnNovoArtista);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1032, 631);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Artistas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnNovoArtista
            // 
            this.btnNovoArtista.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoArtista.FlatAppearance.BorderSize = 0;
            this.btnNovoArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoArtista.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoArtista.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoArtista.Location = new System.Drawing.Point(845, 15);
            this.btnNovoArtista.Name = "btnNovoArtista";
            this.btnNovoArtista.Size = new System.Drawing.Size(170, 40);
            this.btnNovoArtista.TabIndex = 1;
            this.btnNovoArtista.Text = "Novo Artista";
            this.btnNovoArtista.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "ARTISTAS";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnNovoInstrumento);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1032, 631);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Instrumentos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnNovoInstrumento
            // 
            this.btnNovoInstrumento.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoInstrumento.FlatAppearance.BorderSize = 0;
            this.btnNovoInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoInstrumento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoInstrumento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoInstrumento.Location = new System.Drawing.Point(845, 15);
            this.btnNovoInstrumento.Name = "btnNovoInstrumento";
            this.btnNovoInstrumento.Size = new System.Drawing.Size(170, 40);
            this.btnNovoInstrumento.TabIndex = 1;
            this.btnNovoInstrumento.Text = "Novo Instrumento";
            this.btnNovoInstrumento.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "INSTRUMENTOS";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnNovoTipo);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1032, 631);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Tipos";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnNovoTipo
            // 
            this.btnNovoTipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovoTipo.FlatAppearance.BorderSize = 0;
            this.btnNovoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoTipo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovoTipo.Location = new System.Drawing.Point(845, 15);
            this.btnNovoTipo.Name = "btnNovoTipo";
            this.btnNovoTipo.Size = new System.Drawing.Size(170, 40);
            this.btnNovoTipo.TabIndex = 1;
            this.btnNovoTipo.Text = "Novo Tipo";
            this.btnNovoTipo.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "TIPOS";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "FormInicial";
            this.Text = "Form1";
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovoAgendamento;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnNovaSala;
        private System.Windows.Forms.Button btnNovoHorario;
        private System.Windows.Forms.Button btnNovoArtista;
        private System.Windows.Forms.Button btnNovoInstrumento;
        private System.Windows.Forms.Button btnNovoTipo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

