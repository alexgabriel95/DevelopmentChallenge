using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormasGeometricas2
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string ObtenerNombre(Forma forma, int cantidad, int idioma);
        public abstract string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma);


        protected readonly decimal _lado;
        private int cuadrado;

        public int Tipo { get; set; }
        protected decimal BaseMayor { get; }
        protected decimal Altura { get; }
        protected decimal Ancho { get; }
        protected decimal BaseMenor { get; }
        public FormasGeometricas2(int tipo, decimal ancho, decimal baseMenor, decimal baseMayor, decimal altura)
        {
            Tipo = tipo;
            _lado = ancho;
            BaseMayor = baseMayor;
            BaseMayor = baseMenor;
            Altura = altura;
        }

        protected FormasGeometricas2(int cuadrado, decimal ancho)
        {
            this.cuadrado = cuadrado;
            Ancho = ancho;
        }

        public enum Forma
        {
        Cuadrado = 1,
        Triangulo = 2,
        Circulo = 3,
        Trapecio = 4
        }
        public enum Idioma
        {
            Castellano = 1,
            Ingles = 2,
            Italiano = 3
        }

        public class ListaDeClases : FormasGeometricas2
        {
            public List<FormasGeometricas2> Formas { get; set; }

            public ListaDeClases(int tipo, decimal ancho, decimal baseMenor, decimal baseMayor, decimal altura) : base( tipo , ancho, baseMenor, baseMayor, altura)
            {
                Formas = new List<FormasGeometricas2>();
            }

            public override decimal CalcularArea()
            {
                throw new NotImplementedException();
            }

            public override decimal CalcularPerimetro()
            {
                throw new NotImplementedException();
            }

            public override string ObtenerNombre(Forma forma, int cantidad, int idioma)
            {
                throw new NotImplementedException();
            }

            public override string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma)
            {
                throw new NotImplementedException();
            }
        }



        #region
        public class Cuadrado : FormasGeometricas2
        {
            //campo
            private new decimal _lado;
            //constructor
            public Cuadrado(decimal ancho) : base((int)Forma.Cuadrado, ancho)
            {
                _lado = ancho;
            }
            //propiedades
            public decimal Lado 
            {
                get { return _lado; }
                set { _lado = value; }
            }

            public override decimal CalcularArea() 
            {
                return _lado * _lado;
            }

            public override decimal CalcularPerimetro()
            {
                return 4 * _lado;
            }
            public override string ObtenerNombre(Forma forma,int cantidad, int idioma) 
            {

                if (cantidad == 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Cuadrado";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Square";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Cuadrato";
                    }
                }
                else if (cantidad > 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Cuadrados";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Squares";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Cuadrati";
                    }
                }

                return string.Empty;
            }

            public override string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma)
            {
                if (cantidad > 0)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Ingles) 
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    }else if (idioma == (int)Idioma.Italiano) 
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                }

                return string.Empty;
            }


        }

        public class TrianguloEquilatero : FormasGeometricas2 
        {
            private new decimal _lado;

            public TrianguloEquilatero(decimal ancho) : base((int) Forma.Triangulo, ancho)
            {
                _lado = ancho;
            }
            public decimal Lado
            {
                get { return _lado; }
                set { _lado = value; }
            }

            public override decimal CalcularArea()
            {
                return (_lado * _lado * (decimal)Math.Sqrt(3) / 4);
            }

            public override decimal CalcularPerimetro()
            {
                return 3 * _lado;
            }

            public override string ObtenerNombre(Forma forma, int cantidad, int idioma)
            {
                if (cantidad == 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "triangulo";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Triangle";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Triangolo";
                    }
                }
                else if (cantidad > 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "triangulos";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Triangles";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Triangoli";
                    }
                }

                return string.Empty;
            }

            public override string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma)
            {

                if (cantidad > 0)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                }

                return string.Empty;
            }

        }

        public class Circulo : FormasGeometricas2 
        {
            private new decimal _lado;

            public Circulo(decimal ancho) : base((int)Forma.Circulo, ancho)
            {
                _lado = ancho;
            }

            public decimal Radio
            {
                get { return _lado; }
                set { _lado = value; }
            }
            public override decimal CalcularArea()
            {
                return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            }

            public override decimal CalcularPerimetro()
            {
                return (decimal)Math.PI * _lado;
            }
            public override string ObtenerNombre(Forma forma, int cantidad, int idioma)
            {
                if (cantidad == 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Circulo";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Circle";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Cerchio";
                    }
                }
                else if (cantidad > 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Circulos";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Circles";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Cerchi";
                    }
                }

                return string.Empty;
            }

            public override string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma)
            {
                if (cantidad > 0)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                }

                return string.Empty;
            }
        }

        public class TrapecioRectangulo : FormasGeometricas2 
        {
            private decimal _baseMayor;
            private decimal _baseMenor;
            private decimal _altura;
            private decimal _ladoRecto;

            public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura, decimal ancho) : base((int)Forma.Trapecio, ancho)
            {
                _baseMayor = baseMayor;
                _baseMenor = baseMenor;
                _altura = altura;
                _ladoRecto = ancho;
            }


            public decimal LadoRecto
            {
                get { return _ladoRecto; }
                set { _ladoRecto = value; }
            }

            public override decimal CalcularArea()
            {
                return ((_baseMayor + _baseMenor) * _altura) / 2;
            }

            public override decimal CalcularPerimetro()
            {
                return _baseMayor + _baseMenor + LadoRecto + LadoRecto;
            }
            public override string ObtenerNombre(Forma forma, int cantidad, int idioma)
            {
                if (cantidad == 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Trapezio";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Trapezoid";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Trapezio";
                    }
                }
                else if (cantidad > 1)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return "Trapezios";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return "Trapezoids";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return "Trapezio";
                    }
                }

                return string.Empty;
            }

            public override string ObtenerLinea(Forma forma, int cantidad, decimal area, decimal perimetro, int idioma)
            {
                if (cantidad > 0)
                {
                    if (idioma == ((int)Idioma.Castellano))
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Ingles)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                    }
                    else if (idioma == (int)Idioma.Italiano)
                    {
                        return $"{cantidad} {ObtenerNombre(forma, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                    }
                }

                return string.Empty;
            }
        }
        #endregion

        #region 
        public static string Imprimir(List<FormasGeometricas2> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                if (idioma == ((int)Idioma.Castellano))
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else if (idioma == (int)Idioma.Ingles)
                    sb.Append("<h1>Empty list of shapes!</h1>");
                else if (idioma == (int)Idioma.Italiano)
                    sb.Append("<h1>Elenco Vuoto di Forme!</h1>");

            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                if (idioma == (int)Idioma.Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else if (idioma == (int)Idioma.Ingles)
                    // default es inglés
                    sb.Append("<h1>Shapes report</h1>");
                else if (idioma == (int)Idioma.Italiano)
                    sb.Append("<h1>Rapporto di Forme</h1>");

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecios = 0m;

                foreach (var forma in formas)
                {
                    if (forma.Tipo == (int)Forma.Cuadrado)
                    {
                        var cuadrado = new Cuadrado(forma._lado);
                        numeroCuadrados++;
                        areaCuadrados += cuadrado.CalcularArea();
                        perimetroCuadrados += cuadrado.CalcularPerimetro();
                    }
                    if (forma.Tipo == (int)Forma.Triangulo)
                    {
                        var triangulo = new TrianguloEquilatero(forma._lado);
                        numeroTriangulos++;
                        areaTriangulos += triangulo.CalcularArea();
                        perimetroTriangulos += triangulo.CalcularPerimetro();
                    }
                    if (forma.Tipo == (int)Forma.Circulo)
                    {
                        var circulo = new Circulo(forma._lado);
                        numeroCirculos++;
                        areaCirculos += circulo.CalcularArea();
                        perimetroCirculos += circulo.CalcularPerimetro();
                    }
                    if (forma.Tipo == (int)Forma.Trapecio)
                    {
                        var trapecio = new TrapecioRectangulo(forma.BaseMayor, forma.BaseMenor, forma.Altura, forma.Ancho);
                        numeroTrapecios++;
                        areaTrapecios += trapecio.CalcularArea();
                        perimetroTrapecios += trapecio.CalcularPerimetro();
                    }
                }
                Cuadrado formaCuadrado = new Cuadrado(0);
                TrianguloEquilatero formaTrianguloEquilatero = new TrianguloEquilatero(0);
                Circulo formaCirculo = new Circulo(0);
                TrapecioRectangulo formaTrapezio = new TrapecioRectangulo(0, 0 , 0, 0);

                sb.Append(formaCuadrado.ObtenerLinea(Forma.Cuadrado, numeroCuadrados, areaCuadrados, perimetroCuadrados, idioma));
                sb.Append(formaCirculo.ObtenerLinea(Forma.Circulo, numeroCirculos, areaCirculos, perimetroCirculos, idioma));
                sb.Append(formaTrianguloEquilatero.ObtenerLinea(Forma.Triangulo, numeroTriangulos, areaTriangulos, perimetroTriangulos, idioma));
                sb.Append(formaTrapezio.ObtenerLinea(Forma.Trapecio, numeroTrapecios, areaTrapecios, perimetroTrapecios, idioma));
                
                // FOOTER
                sb.Append("TOTAL:<br/>");

                if (idioma == (int)Idioma.Castellano)
                {
                    sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "formas" + " ");
                    sb.Append("Perimetro " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
                }
                else if (idioma == (int)Idioma.Ingles)
                {
                    sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "shapes" + " ");
                    sb.Append("Perimeter " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
                }
                else if (idioma == (int)Idioma.Italiano)
                {
                    sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "forme" + " ");
                    sb.Append("Perimetro " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios).ToString("#.##") + " ");
                }

                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios).ToString("#.##"));
            }
            Console.WriteLine(sb.ToString());
          

            return sb.ToString();
                
        }
        #endregion
    }

}
