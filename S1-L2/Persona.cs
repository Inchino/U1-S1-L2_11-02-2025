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

        public void Saluti()
        {
            Console.WriteLine($"Salve, mi chiamo {Nome} {Cognome} ed ho {Eta} anni!");
        }
    }
}
