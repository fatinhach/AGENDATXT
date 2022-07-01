namespace AGENDA
{
    partial class frmTexto
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
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_texto = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_pesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_pesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd_pesquisar.Location = new System.Drawing.Point(211, 138);
            this.cmd_pesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(86, 36);
            this.cmd_pesquisar.TabIndex = 0;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termo de Pesquisa";
            // 
            // text_texto
            // 
            this.text_texto.Location = new System.Drawing.Point(14, 36);
            this.text_texto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(283, 27);
            this.text_texto.TabIndex = 2;
            this.text_texto.TextChanged += new System.EventHandler(this.text_texto_TextChanged);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd_cancelar.Location = new System.Drawing.Point(12, 138);
            this.cmd_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(86, 36);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe apenas o primeiro nome,";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ou se preferir, o nome completo.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(309, 180);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.Load += new System.EventHandler(this.frmTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_pesquisar;
        private Label label1;
        private TextBox text_texto;
        private Button cmd_cancelar;
        private Label label2;
        private Label label3;
    }
}