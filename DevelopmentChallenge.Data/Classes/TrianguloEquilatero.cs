using System;


namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormasGeometricas
    {
        private readonly decimal _lado;
        public static int Numero { get; private set; }
        public static decimal Area { get; private set; }
        public static decimal Perimetro { get; private set; }
        public TrianguloEquilatero(decimal ancho)
        {
            _lado = ancho;
            Numero += 1;
        }
        public TrianguloEquilatero()
        {

        }
        public override decimal CalcularArea()
        {
            Area += ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            Perimetro += _lado * 3;
            return _lado * 3;
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
            return Numero == 1 ? idioma.BuscarText("Triángulo") : idioma.BuscarText("Triángulos");
        }

    }
}
