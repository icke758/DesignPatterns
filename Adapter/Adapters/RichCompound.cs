using Adapter.Adaptees;
using Adapter.Targets;
using static Program;

namespace Adapter.Adapters
{
    public class RichCompound : Compound
    {
        private readonly string? chemical;
        private ChemicalDatabank? bank;

        public RichCompound(string chemmical) => chemical = chemmical;

        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            Console.WriteLine("\nCompound: {0} ------ ", chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);
        }
    }
}
