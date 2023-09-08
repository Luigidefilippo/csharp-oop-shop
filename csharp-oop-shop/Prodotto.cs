using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        //ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private decimal prezzo; 
        private decimal iva;

        //CODICE SOLO IN LETTURA 
        public int Codice => codice;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //ottenere o impostare la descrizione 
        public string Descrizione
        {
            get { return descrizione;}
            set { descrizione = value; }
        }

        public decimal IVA
        {
            get { return iva; }
            set { iva = value; }
        }

        public decimal Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        
    }
}
