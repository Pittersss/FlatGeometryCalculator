using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneGeometryCalculator
{
     public abstract class Areas
        {
            public abstract void ATriangulo(double Base, double height);
            public abstract void ATrianguloEquilatero(double side);
            public abstract void AQuadrado(double side);
            public abstract void ATrapezio(double biggerB, double lesserB, double height);
            public abstract void ALosango(double biggerD, double lesserD);
            public abstract void ARetangulo(double Base, double height);
            public abstract void ACirculo(double radius);
            public abstract void AParalelogramo(double Base, double height);
        }
    
}
