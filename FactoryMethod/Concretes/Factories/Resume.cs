using FactoryMethod.Abstracts.Factories;
using static FactoryMethod.Concretes.Products;

namespace FactoryMethod.Concretes.Factories
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
