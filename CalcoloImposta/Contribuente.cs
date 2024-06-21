using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloImposta
{
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string Comune { get; set; }
        public decimal RedditoAnnuale { get; set; }

        public Contribuente(string nome, string cognome, DateTime datadinascita, string comune, string codiceFiscale, string sesso, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = datadinascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            Comune = comune;
            RedditoAnnuale = redditoAnnuale;
        }

        public decimal Calcolo()
        {
            decimal imposta = 0;
            decimal reddito = RedditoAnnuale;

            if (reddito < 15000)
            {
                imposta = reddito * 0.23m;
            }
            else if (reddito <= 28000) 
            { 
                imposta = 3450 + (reddito - 15000) * 0.27m; 

            }
            else if (reddito <= 55000)
            {
                imposta = 6960 + (reddito - 28000) * 0.38m;
            }
            else if (reddito <= 75000)
            {
                imposta = 17220 + (reddito - 55000) * 0.41m;
            }
            else
            {
                imposta = 25420 + (reddito - 75000) * 0.43m;
            }

            return imposta;




        }
    }
}
