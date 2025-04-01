
namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : Idiomas
    {
        public override string Sintitulo()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }
        public override string Ponertitulo()
        {
            return "<h1>Modulo Segnala</h1>";
        }
        public override string BuscarText(string palabra)
        {
            switch (palabra.ToUpper())
            {
                case "FORMAS":
                    return "forme ";
                case "PERIMETRO":
                    return "Perimetro ";
                case "CUADRADO":
                    return "piazza ";
                case "CUADRADOS":
                    return "Piazzas ";
                case "CÍRCULO":
                    return "cerchio ";
                case "CÍRCULOS":
                    return "cerchios ";
                case "TRIÁNGULO":
                    return "Triangolo ";
                case "TRIÁNGULOS":
                    return "Triangolos ";
                case "TOTAL":
                    return "Totale ";
                case "AREA":
                    return "Zona ";
            }
            return palabra + " ";
        }
    }
}

