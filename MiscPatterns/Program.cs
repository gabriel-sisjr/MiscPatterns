using System;
using System.Collections.Generic;
using MiscPatterns.Abstracts;
using MiscPatterns.Concretes;

namespace MiscPatterns
{
    class Program
    {
        static void Main()
        {
            // Veja na instancia ele chama a classe abstrata.
            var docs = new List<Document>(2) { new Resume(), new Report() };

            foreach (var doc in docs)
            {
                Console.WriteLine(doc.GetType().Name);
                foreach (var page in doc.Pages)
                    Console.WriteLine($"\t {page.GetType().Name}");

                Console.WriteLine();
            }
        }
    }
}
