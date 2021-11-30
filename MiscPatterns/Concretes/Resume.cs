using System;
using MiscPatterns.Abstracts;

namespace MiscPatterns.Concretes
{
    public class Resume : Document
    {
        // Implementa o metódo do factory
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}

