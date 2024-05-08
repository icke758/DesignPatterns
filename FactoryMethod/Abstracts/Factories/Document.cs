using System;
using System.Collections.Generic;
using System.Linq;
using static FactoryMethod.Abstracts.Products;

namespace FactoryMethod.Abstracts.Factories
{
    public abstract class Document
    {
        private readonly List<Page> _page = new();

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get { return _page; } }

        public abstract void CreatePages();
    }
}
