/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<FormasGeometricas> formas, Idiomas idioma)
        {
            var sb = new StringBuilder();
            if (!formas.Any())
            {
                sb.Append(idioma.Sintitulo());
            }
            else
            {
                sb.Append(idioma.Ponertitulo());

                var area = 0m;
                var perimetro = 0m;

                foreach (FormasGeometricas forma in formas)
                {
                    area += forma.CalcularArea();
                    perimetro += forma.CalcularPerimetro();
                }

                Cuadrado cuadrado = new Cuadrado();
                Circulo circulo = new Circulo();
                TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero();
                Trapecio trapecio = new Trapecio();
                Rectangulo rectangulo = new Rectangulo();

                sb.Append(cuadrado.ObtenerLinea(idioma));
                sb.Append(circulo.ObtenerLinea(idioma));
                sb.Append(trianguloEquilatero.ObtenerLinea(idioma));
                sb.Append(trapecio.ObtenerLinea(idioma));
                sb.Append(rectangulo.ObtenerLinea(idioma));

                // FOOTER
                sb.Append(idioma.BuscarText("TOTAL").TrimEnd() + ":<br/>");
                sb.Append(formas.Count + " " + idioma.BuscarText("formas"));

                sb.Append(idioma.BuscarText("Perimetro") + (perimetro).ToString("#.##") + " ");
                sb.Append(idioma.BuscarText("Area") + (area).ToString("#.##"));
            }

            return sb.ToString();
        }
    }
}
