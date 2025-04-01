

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormasGeometricas
    {
        private readonly decimal _lado;
        public static int Numero { get; private set; }
        public static decimal Area { get; private set; }
        public static decimal Perimetro { get; private set; }

        public Cuadrado(decimal ancho)
        {
            _lado = ancho;
            Numero += 1;
        }
        public Cuadrado()
        {
        }

        public override decimal CalcularArea()
        {
            Area += _lado * _lado;
            return _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            Perimetro += _lado * 4;
            return _lado * 4;
        }
        public override string ObtenerLinea(Idiomas idioma)
        {
            if (Numero > 0)
            {
                return $"{Numero} {TraducirForma(idioma)}| " + idioma.BuscarText("Area") + $"{Area:#.##} | " + idioma.BuscarText("Perimetro") + $"{Perimetro:#.##} <br/>";
            }
            return "";
        }
        private string TraducirForma(Idiomas idioma)
        {
            return Numero == 1 ? idioma.BuscarText("Cuadrado") : idioma.BuscarText("Cuadrados");
        }
    }
}
