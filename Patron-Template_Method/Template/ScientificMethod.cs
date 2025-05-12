namespace patron_template_method.Template
{
    public abstract class ScientificMethod
    {
        public void Execute()
        {
            Observe();
            FormulateHypothesis();
            Experimentation();
            AnalyzeData();
            DrawConclusion();
            PublishResults();
        }

        protected virtual void Observe()
        {
            Console.WriteLine("[Observación] Se observa un fenómeno interesante.");
        }

        protected abstract void FormulateHypothesis();
        protected abstract void Experimentation();
        protected abstract void AnalyzeData();

        protected virtual void DrawConclusion()
        {
            Console.WriteLine("[Conclusión] Se extrae una conclusión basada en los datos.");
        }

        protected virtual void PublishResults()
        {
            Console.WriteLine("[Publicación] Resultados publicados en una revista científica.");
        }
    }
}