using System;
using MiscPatterns.Abstracts;

namespace MiscPatterns.Concretes
{
    public class Report : Document
    {
        // Mesma coisa dos outros
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}

