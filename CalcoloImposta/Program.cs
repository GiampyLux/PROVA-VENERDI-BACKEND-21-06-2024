namespace CalcoloImposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Insercisi la tua data di nascita");
            DateTime datadinascita = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il codice fiscale:");
            string codiceFiscale = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo Genere");
            string sesso = Console.ReadLine();

            Console.WriteLine("Inserisci il comune");
            string comune = Console.ReadLine();

            Console.WriteLine("Inserisci il reddito");
            decimal reddito = decimal.Parse(Console.ReadLine());


            Contribuente contribuente = new Contribuente(nome, cognome, datadinascita, comune, codiceFiscale, sesso, reddito);

            decimal impostaDaVers = contribuente.Calcolo();
            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataDiNascita:dd/MM/yyyy} ({contribuente.Sesso}),");
            Console.WriteLine($"residente in {contribuente.Comune},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {impostaDaVers}");
        }
    }
}
