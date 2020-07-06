using System.Collections.Generic;
using System.IO;

namespace AulaWhatsapp
{
   public class Agenda : IAgenda
    {
        List<Contato> contato = new List<Contato>();

        private const string PATH = "Database/produto.csv";

         //criando pasta
        public Agenda()
        {
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
          
          //Fazendo uma linha bem estruturada  return $"nome={tel.Nome};telefone={tel.Telefone}";
        public void Cadastrar(Contato tel)
        {
            var linha = new string [] {FazendoLinha(tel)};
            File.AppendAllLines(PATH, linha);   
        }
          private string FazendoLinha(Contato tel)
        {
            return $"nome={tel.Nome};telefone={tel.Telefone}";
        }
        //Método de excluir coisa indesejada da linha
        public void Excluir(string Contato)
        {
            // lista de string para salvar as linhas do csv
            List<string> linhas = new List<string>();

            // o using para abrir e fechar o arquivo 
            using(StreamReader file = new StreamReader(PATH)){
            
                string line;
                while ((line = file.ReadLine())!= null){
                    linhas.Add(line);
                }
                //Removendo todas as linhas que tenha o contato
                linhas.RemoveAll(l => l.Contains(Contato));
            }
            //Reescrevendo o arquivo
            using (StreamWriter output = new StreamWriter(PATH)){
                foreach(string ln in linhas){
                output.Write(ln + "\n");
                }
            }
        }

         public void Listar()
        {
            List<string> linhas = new List<string>();

           
            using(StreamReader file = new StreamReader(PATH))
            {
            
                string line;
                while ((line = file.ReadLine())!= null)
                 {
                    linhas.Add(line);
                 }
            }
        }
        
        
       
    }
    
    

}