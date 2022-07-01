using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDA
{
    public partial class frmInserirEditar : Form
      
    {
        int indice;
        public frmInserirEditar()
        {
            InitializeComponent();
            Construirlista();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechar o quadro
            this.Close();
        }

       
        private void frmInserirEditar_Load(object sender, EventArgs e)
        {
        }

        private void Construirlista()
        {
            lista_contatos.Items.Clear();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + "(" + contato.numero + ")");
            }

            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count;

            //impedir edição e eliminação do registro
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;

        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //gravar as informações

            //verificar se os campos estão preechidos
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão preenchidos.");
                return;
            }
            //verificar se ja possui um registro igual
            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome == text_nome.Text &&
                   contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! Esse registro já existe. ");
                    return;
                }
            }

            cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            Construirlista();

            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();

        }
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        if (lista_contatos.SelectedIndex == -1) return;


        indice = lista_contatos.SelectedIndex;
            cmd_editar.Enabled = true;
            cmd_apagar.Enabled = true;

        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga o registro selecionado

            //eliminando registro
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);
            //renovar o ficheiro
            cl_geral.GravarFicheiro();
            //reconstroi a lista com os dados
            Construirlista();
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {

        }
    }


}
