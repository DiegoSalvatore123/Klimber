

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : Idiomas
    {
        public override string Sintitulo()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }
        public override string Ponertitulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }
        public override string BuscarText(string palabra)
        {
            return palabra + " ";
        }
    }
}
