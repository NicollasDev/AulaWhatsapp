using System;
using AulaWhatsapp;

class Program
    {
        static void Main(string[] args)
        {
            Contato contato1 = new Contato("NdL", 98273641);
            Contato contato2 = new Contato("Gnomin", 928462869);
            Contato contato3 = new Contato("MemeuPepeu", 952789468);
            Contato contato4 = new Contato("Laurinha Programadora", 952346919);
            Contato contato5 = new Contato("Ygorzeraaa", 977346718);
            Contato contato6 = new Contato("Dextron", 983823542);
            

            

            Agenda agendasteam = new Agenda();
            agendasteam.Cadastrar(contato1);
            agendasteam.Cadastrar(contato2);
            agendasteam.Cadastrar(contato3);
            agendasteam.Cadastrar(contato4);
            agendasteam.Cadastrar(contato5);
            agendasteam.Cadastrar(contato6);
            

            agendasteam.Excluir("Laurinha Programadora");
            Mensagem Frase = new Mensagem();
            Frase.Destinatario = contato1;
        
            System.Console.WriteLine(Frase.Enviar(Frase.Destinatario));
 

            
            
        }
    }

