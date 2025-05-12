using patron_template_method.Template;

namespace patron_template_method.Researchers
{
    public class VaccineResearcher : ScientificMethod
    {
        protected override void FormulateHypothesis()
        {
            Console.WriteLine("[Hipótesis] Esta sustancia puede generar inmunidad.");
        }

        protected override void Experimentation()
        {
            Console.WriteLine("[Experimentación] Se realizan pruebas clínicas en voluntarios.");
        }

        protected override void AnalyzeData()
        {
            Console.WriteLine("[Análisis] Se comparan respuestas inmunes entre grupos.");
        }
    }
    
}