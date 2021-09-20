using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneGeometryCalculator
{
    class Calcula : Areas, IPerimetro
    {
        public static double area;
        public static double perimetro;

        //Area

        public override void ATriangulo(double Base, double height)
        {
            area = Base * height / 2;
        }
        public override void ATrianguloEquilatero(double side)
        {
            area = Math.Pow(side, 2) * Math.Sqrt(3) / 4;
        }
        public override void AQuadrado(double side)
        {
            area = Math.Pow(side, 2);
        }
        public override void ATrapezio(double biggerB, double lesserB, double height)
        {
            area = height * (biggerB + lesserB) / 2;
        }
        public override void ALosango(double biggerD, double lesserD)
        {
            area = biggerD * lesserD / 2;
        }
        public override void ARetangulo(double Base, double height)
        {
            area = Base * height;
        }
        public override void ACirculo(double radius)
        {
            area = Math.PI * Math.Pow(radius, 2);
        }
        public override void AParalelogramo(double Base, double height)
        {
            area = Base * height;
        }

        //Interface
        public void PRetangulo(double biggerSide, double lesserSide)
        {
            perimetro = (2 * biggerSide) + (2 * lesserSide);
        }
        public void PQuadrado(double side)
        {
            perimetro = 4 * side;
        }
        public void PParalelogramo(double biggerSide, double lesserSide)
        {
            perimetro = (2 * biggerSide) + (2 * lesserSide);
        }
        public void PCirculo(double radius)
        {
            perimetro = (2 * Math.PI * radius);
        }
        public void PLosango(double side)
        {
            perimetro = side * 4;
        }
        public void PTrapezio(double sideA, double sideB, double sideb, double sideC)
        {
            perimetro = sideA + sideb + sideB + sideC;
        }

        public void PTrianguloEquilatero(double side)
        {
            perimetro = side * 3;
        }
        public void PTriangulo(double sideA, double sideB, double sideC)
        {
            perimetro = sideA + sideB + sideC;
        }


    }
}
