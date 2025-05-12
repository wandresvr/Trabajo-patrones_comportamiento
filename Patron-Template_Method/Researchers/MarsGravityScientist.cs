using patron_template_method.Template;

namespace patron_template_method.Researchers
{
    public class MarsGravityScientist : ScientificMethod
    {
        protected override void FormulateHypothesis()
        {
            Console.WriteLine("[Hipótesis] La gravedad en Marte es menor que en la Tierra.");
        }

        protected override void Experimentation()
        {
            Console.WriteLine("[Experimentación] Se lanzan objetos desde distintas alturas.");
        }

        protected override void AnalyzeData()
        {
            Console.WriteLine("[Análisis] Se calculan tiempos de caída y aceleraciones.");
        }
    }
    
}