namespace AulaWhatsapp
{
    public class Mensagem
    {
      public string MensagemFrase = "Go cs?";
      public Contato Destinatario { get; set; }

      public string Enviar(Contato contato)
        {   
            
             return $"Enviar a mensagem: '{MensagemFrase}' enviando para: {Destinatario.Nome}";
        }
    }
}
    
