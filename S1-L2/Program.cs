using System;
using Esercizio2;

class Program
{
    static void Main(string[] args)
    {

        Persona p = new Persona();
        p.GetNome();
        p.GetCognome();
        p.GetEta();

        p.GetDettagli();
        Console.WriteLine("Premere INVIO per uscire dal programma");
        Console.ReadLine();
    }
}
