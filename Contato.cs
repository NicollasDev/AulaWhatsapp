namespace AulaWhatsapp
{
    public class Contato
    {
        public string Nome;
        public int Telefone;

        public Contato(){

        }
        public Contato(string _nome, int _telefone){
        this.Telefone = _telefone;
        this.Nome = _nome;
        }
    }
}