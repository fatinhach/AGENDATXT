namespace AGENDA
{
    partial class frmresultados
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
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(203, 201);
            this.cmd_nova_pesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(133, 41);
            this.cmd_nova_pesquisa.TabIndex = 0;
            this.cmd_nova_pesquisa.Text = "Nova pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_nova_pesquisa_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Red;
            this.cmd_fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_fechar.ForeColor = System.Drawing.Color.White;
            this.cmd_fechar.Location = new System.Drawing.Point(356, 201);
            this.cmd_fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(97, 41);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click_1);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.ItemHeight = 20;
            this.lista_final.Location = new System.Drawing.Point(14, 16);
            this.lista_final.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(439, 164);
            this.lista_final.TabIndex = 2;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_numero_registros.ForeColor = System.Drawing.Color.Red;
            this.label_numero_registros.Location = new System.Drawing.Point(14, 185);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(92, 20);
            this.label_numero_registros.TabIndex = 9;
            this.label_numero_registros.Text = "Registros: 0";
            // 
            // frmresultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(467, 266);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmresultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.Load += new System.EventHandler(this.frmresultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_nova_pesquisa;
        private Button cmd_fechar;
        private ListBox lista_final;
        private Label label_numero_registros;
    }
}