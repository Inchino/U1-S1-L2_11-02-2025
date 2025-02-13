using System;

namespace Esercizio2
{
    public class Persona
    {
        private string _nome = string.Empty;
        private string _cognome = string.Empty;
        private int _eta = 0;

        public string Nome
        {
            get => _nome;
            set => _nome = value ?? string.Empty;
        }

        public string Cognome
        {
            get => _cognome;
            set => _cognome = value ?? string.Empty;
        }

        public int Eta
        {
            get => _eta;
            set => _eta = value >= 0 ? value : 0;
        }

        public void GetNome()
        {
            Console.WriteLine("Inserire il nome della persona: ");
            _nome = Console.ReadLine();
        }
        public void GetCognome()
        {
            Console.WriteLine("Inserire il cognome della persona: ");
            _cognome = Console.ReadLine();
        }
        public void GetEta()
        {
            Console.WriteLine("Inserire l'età della persona: ");
            _eta = int.Parse(Console.ReadLine());
        }
        public void GetDettagli()
        {
            Console.WriteLine($"\n---------------------------------------------\n\nI dettagli della persona sono: \n - Nome: {Nome} \n - Cognome: {Cognome} \n - Età: {Eta} \n");
        }
    }
}
