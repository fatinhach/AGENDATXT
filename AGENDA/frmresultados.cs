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
    public partial class frmresultados : Form
    {
        string texto;

        public frmresultados(string texto)
        {
            InitializeComponent();
        

            this.texto = texto.ToUpper();
        }

        private void frmresultados_Load(object sender, EventArgs e)
        {
            //executa a  pesquisa
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e mostra os dados
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome.ToUpper().Contains(texto) ||
                   contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }

            //apresentar
            lista_final.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
                lista_final.Items.Add(contato.nome + " (" + contato.numero + ")");

            label_numero_registros.Text = "Registros: " + lista_final.Items.Count;
        }
        

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            frmTexto f = new frmTexto();
            f.ShowDialog();

            //quando fechar o quadro
            if (f.cancelado) return;

            texto = f.texto.ToUpper();

            ExecutaPesquisa();
        }

        private void cmd_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
