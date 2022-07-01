using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AGENDA
{
    public static class cl_geral
    {   //Mostra a vesrsão da agenda
        public static string versao = " v 2.0.2.1";

        //Estrutura da lista de contatos
        public static List<cl_contato> LISTA_CONTATOS;

        public static void ConstruirListaContatos()

        {
        //carregar a lista de contatos

        string pasta_Areadetrabalho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string nome_ficheiro = pasta_Areadetrabalho + @"\ficheiro_contatos.txt";

         //criar a lista vazia, caso não teha um txt.
        LISTA_CONTATOS = new List<cl_contato>();

        if (!File.Exists(nome_ficheiro))
            {
        //finaliza aqui 
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                while (!ficheiro.EndOfStream)
                {
         //carregar nome do funcionario
         string nome = ficheiro.ReadLine();

         //carregar o número do funcionario
         string numero = ficheiro.ReadLine();

          //adicianar a lista para carregar os dados
         cl_contato novo_contato = new cl_contato();
         novo_contato.nome = nome;
          novo_contato.numero = numero;
         LISTA_CONTATOS.Add(novo_contato);
                }
                ficheiro.Dispose();
            }

        }

        public static void GravarNovoRegistro(string _nome, string _numero)
        {
         //cl_contato novo = new cl_contato();
         //novo.nome = _nome;
         //novo.numero = _numero;
         //LISTA_CONTATOS.Add(novo);

         LISTA_CONTATOS.Add(new cl_contato() { nome = _nome, numero = _numero });

         // atualizar
            GravarFicheiro();
        }
        public static void GravarFicheiro()
        {
        string pasta_Areadetrabalho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string nome_ficheiro = pasta_Areadetrabalho + @"\ficheiro_contatos.txt";

        StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
        foreach (cl_contato contato in LISTA_CONTATOS)
         {
         ficheiro.WriteLine(contato.nome);
         ficheiro.WriteLine(contato.numero);

                  }

              { 
                ficheiro.Dispose();
            }

        }
    }

}