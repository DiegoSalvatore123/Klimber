
namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormasGeometricas
    {
        private readonly decimal _lado;
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public static int Numero { get; private set; }
        public static decimal Area { get; private set; }
        public static decimal Perimetro { get; private set; }
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lado, decimal altura)
        {
            _lado = lado;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            Numero += 1;
        }
        public Trapecio()
        {
        }
        public override decimal CalcularArea()
        {
            Area += ((_baseMayor + _baseMenor) * _altura) / 2;
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }
        public override decimal CalcularPerimetro()
        {
            Perimetro += _baseMayor + _baseMenor + _lado + _lado;
            return _baseMayor + _baseMenor + _lado + _lado;
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

