using FactoryMethod.Abstracts.Factories;
using FactoryMethod.Concretes.Factories;
using static FactoryMethod.Abstracts.Products;

internal class Program
{
    private static void Main()
    {
        Document[] documents = new Document[2];
        documents[0] = new Resume();
        documents[1] = new Report();

        foreach (var document in documents)
        {
            Console.WriteLine($"{document.GetType().Name} -- ");
            foreach(Page page in document.Pages)
            {
                Console.WriteLine($"- {page.GetType().Name}");
            }
        }
        Console.ReadKey();
    }
}