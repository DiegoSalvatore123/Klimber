namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormasGeometricas
    {
        private readonly decimal _largo;
        private readonly decimal _alto;

        public static int Numero { get; private set; }
        public static decimal Area { get; private set; }
        public static decimal Perimetro { get; private set; }

        public Rectangulo(decimal largo, decimal alto)
        {
            _largo = largo;
            _alto = alto;

            Numero += 1;
        }
        public Rectangulo()
        {
        }

        public override decimal CalcularArea()
        {
            Area += _largo * _alto;
            return _largo * _alto;
        }
        public override decimal CalcularPerimetro()
        {
            Perimetro += (_largo * 2) + (_alto * 2);
            return (_largo * 2) + (_alto * 2);
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
