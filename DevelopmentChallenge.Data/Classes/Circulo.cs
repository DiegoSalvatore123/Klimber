using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormasGeometricas
    {
        private readonly decimal _lado;
        public static int Numero { get; private set; }
        public static decimal Area { get; private set; }
        public static decimal Perimetro { get; private set; }

        public Circulo(decimal ancho)
        {
            _lado = ancho;
            Numero += 1;
        }
        public Circulo()
        {

        }
        public override decimal CalcularArea()
        {
            Area += (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }
        public override decimal CalcularPerimetro()
        {
            Perimetro += (decimal)Math.PI * _lado;
            return (decimal)Math.PI * _lado;
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
            return Numero == 1 ? idioma.BuscarText("Círculo") : idioma.BuscarText("Círculos");
        }
    }
}


