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


    }
}
