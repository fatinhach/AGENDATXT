namespace AGENDA
{
    partial class frmMenu
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
            this.cmd_inserir_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_pesquiasr = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_inserir_editar
            // 
            this.cmd_inserir_editar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_inserir_editar.Location = new System.Drawing.Point(151, 121);
            this.cmd_inserir_editar.Name = "cmd_inserir_editar";
            this.cmd_inserir_editar.Size = new System.Drawing.Size(148, 41);
            this.cmd_inserir_editar.TabIndex = 0;
            this.cmd_inserir_editar.Text = "Registrar contato";
            this.cmd_inserir_editar.UseVisualStyleBackColor = true;
            this.cmd_inserir_editar.Click += new System.EventHandler(this.cmd_inserir_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "AGENDA TELEFÔNICA";
            // 
            // cmd_pesquiasr
            // 
            this.cmd_pesquiasr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_pesquiasr.Location = new System.Drawing.Point(151, 202);
            this.cmd_pesquiasr.Name = "cmd_pesquiasr";
            this.cmd_pesquiasr.Size = new System.Drawing.Size(148, 41);
            this.cmd_pesquiasr.TabIndex = 4;
            this.cmd_pesquiasr.Text = "Pesquisar contato";
            this.cmd_pesquiasr.UseVisualStyleBackColor = true;
            this.cmd_pesquiasr.Click += new System.EventHandler(this.cmd_pesquiasr_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.BackColor = System.Drawing.Color.Red;
            this.cmd_sair.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmd_sair.Location = new System.Drawing.Point(151, 278);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(148, 41);
            this.cmd_sair.TabIndex = 5;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = false;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label_versao
            // 
            this.label_versao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_versao.Location = new System.Drawing.Point(26, 384);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(400, 42);
            this.label_versao.TabIndex = 6;
            this.label_versao.Text = "Apresenta a versão do programa";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(464, 451);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquiasr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_inserir_editar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "AGENDA TELEFÔNICA ©REMAY©";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_inserir_editar;
        private Label label1;
        private Button cmd_pesquiasr;
        private Button cmd_sair;
        private Label label_versao;
    }
}