namespace AGENDA
{
    partial class frmInserirEditar
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Red;
            this.cmd_fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.cmd_fechar.Location = new System.Drawing.Point(363, 377);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(103, 45);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(71, 31);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(405, 27);
            this.text_nome.TabIndex = 2;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(71, 77);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(163, 27);
            this.text_numero.TabIndex = 4;
            this.text_numero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_gravar.Location = new System.Drawing.Point(71, 120);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(95, 33);
            this.cmd_gravar.TabIndex = 5;
            this.cmd_gravar.Text = "Salvar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.ItemHeight = 20;
            this.lista_contatos.Location = new System.Drawing.Point(25, 189);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(441, 164);
            this.lista_contatos.TabIndex = 6;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de contatos registrados:";
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_numero_registros.ForeColor = System.Drawing.Color.Red;
            this.label_numero_registros.Location = new System.Drawing.Point(24, 357);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(92, 20);
            this.label_numero_registros.TabIndex = 8;
            this.label_numero_registros.Text = "Registros: 0";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_apagar.Location = new System.Drawing.Point(254, 377);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(103, 45);
            this.cmd_apagar.TabIndex = 9;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_editar.Location = new System.Drawing.Point(145, 377);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(103, 45);
            this.cmd_editar.TabIndex = 10;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(484, 467);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA REMAY INSERIR OU EDITAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_fechar;
        private Label label1;
        private TextBox text_nome;
        private TextBox text_numero;
        private Label label2;
        private Button cmd_gravar;
        private ListBox lista_contatos;
        private Label label3;
        private Label label_numero_registros;
        private Button cmd_apagar;
        private Button cmd_editar;
    }
}