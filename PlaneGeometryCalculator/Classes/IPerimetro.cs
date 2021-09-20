using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneGeometryCalculator
{
 public interface IPerimetro
{
 void PRetangulo(double biggerSide, double lesserSide);
 void PQuadrado(double side);
 void PParalelogramo(double biggerSide, double lesserSide);
 void PCirculo(double radius);
 void PLosango(double side);
 void PTrapezio(double sideA, double sideB, double sideb, double sideC);
 void PTrianguloEquilatero(double side);
 void PTriangulo(double sideA, double sideB, double sideC);
}
}
