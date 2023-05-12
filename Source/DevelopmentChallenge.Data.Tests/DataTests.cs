using System;
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
                FormasGeometricas2.Imprimir(new List<FormasGeometricas2>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormasGeometricas2.Imprimir(new List<FormasGeometricas2>(), 2));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormasGeometricas2> { new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 5, 0, 0, 0) };

            var resumen = FormasGeometricas2.Imprimir(cuadrados, (int)FormasGeometricas2.Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormasGeometricas2>
            {
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 5, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 1, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 3, 0, 0, 0)

            };

            var resumen = FormasGeometricas2.Imprimir(cuadrados, (int)FormasGeometricas2.Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormasGeometricas2>
            {
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 5, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Circulo, 3, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 4, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 2, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 9, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Circulo, 2.75m, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 4.2m, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Trapecio, 4, 5, 8, 9),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Trapecio, 3, 4, 7, 8),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Trapecio, 2, 3, 6, 7)
            };

            var resumen = FormasGeometricas2.Imprimir(formas, (int)FormasGeometricas2.Idioma.Ingles);

            Console.WriteLine(resumen);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>3 Trapezoids | Area 49 | Perimeter 12 <br/>TOTAL:<br/>7 shapes Perimeter 109,66 Area 140,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormasGeometricas2>
            {
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 5, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Circulo, 3, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 4, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Cuadrado, 2, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 9, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Circulo, 2.75m, 0, 0, 0),
                new FormasGeometricas2.ListaDeClases((int)FormasGeometricas2.Forma.Triangulo, 4.2m, 0, 0, 0)
            };

            var resumen = FormasGeometricas2.Imprimir(formas, (int)FormasGeometricas2.Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13,01 | Perimetro 18,06 <br/>3 triangulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
