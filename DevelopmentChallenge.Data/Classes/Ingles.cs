

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : Idiomas
    {
        public override string Sintitulo()
        {
            return "<h1>Empty list of shapes!</h1>";
        }
        public override string Ponertitulo()
        {
            return "<h1>Shapes report</h1>";
        }
        public override string BuscarText(string palabra)
        {
            switch (palabra.ToUpper())
            {
                case "FORMAS":
                    return "shapes ";
                case "PERIMETRO":
                    return "Perimeter ";
                case "CUADRADO":
                    return "Square ";
                case "CUADRADOS":
                    return "Squares ";
                case "CÍRCULO":
                    return "Circle ";
                case "CÍRCULOS":
                    return "Circles ";
                case "TRIÁNGULO":
                    return "Triangle ";
                case "TRIÁNGULOS":
                    return "Triangles ";
            }
            return palabra + " ";
        }
    }
}

