﻿using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormasGeometricas>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormasGeometricas>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            //   var cuadrados = new List<FormaGeometrica> {new FormasGeometricas(FormaGeometrica.Cuadrado, 5)};
            List<FormasGeometricas> lst = new List<FormasGeometricas>();
            Cuadrado cuadrado = new Cuadrado(5);
            lst.Add(cuadrado);
            var resumen = FormaGeometrica.Imprimir(lst, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            List<FormasGeometricas> cuadrados = new List<FormasGeometricas>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            List<FormasGeometricas> formas = new List<FormasGeometricas>
            {
                new Cuadrado( 5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            List<FormasGeometricas> formas = new List<FormasGeometricas>
            {
                  new Cuadrado( 5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
