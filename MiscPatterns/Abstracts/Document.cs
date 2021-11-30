using System;
using System.Collections.Generic;

namespace MiscPatterns.Abstracts
{
    public abstract class Document
    {
        // Metódo Factory
        public abstract void CreatePages();

        // Props
        private readonly List<Page> _pages = new();

        // ctor
        public Document() => CreatePages();

        public List<Page> Pages => _pages;
    }
}