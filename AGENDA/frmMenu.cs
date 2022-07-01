namespace AGENDA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            //carrega os contatos
            cl_geral.ConstruirListaContatos();

            //apresenta versão do programa
            label_versao.Text = cl_geral.versao;
        }
        private void frmMenu_Load(object sender, EventArgs e)
            { 
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //sair da navegação

            //pergunta se realmente deseja sair.
            if (MessageBox.Show("Deseja sair da navegação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            Application.Exit();
        }

        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            //vai para os contatos
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }

        private void cmd_pesquiasr_Click(object sender, EventArgs e)
        {
            //abrir o quadro pesquisa
            frmTexto f = new frmTexto();
            f.ShowDialog();


            // quando fechar o quadro, verifica se foi cancelado
            if (f.cancelado) return;

            //abrir quadros com resultados
            frmresultados ff = new frmresultados(f.texto);
            ff.ShowDialog();
        }
        
    }
}