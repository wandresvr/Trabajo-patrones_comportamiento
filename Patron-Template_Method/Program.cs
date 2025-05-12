using patron_template_method.Researchers;
using patron_template_method.Template;

namespace patron_template_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Investigador de vacunas ===");
            ScientificMethod researcher1 = new VaccineResearcher();
            researcher1.Execute();

            Console.WriteLine("\n=== Científico en Marte ===");
            ScientificMethod researcher2 = new MarsGravityScientist();
            researcher2.Execute();
        }
    }
}
