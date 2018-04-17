using System;
using System.Collections.Generic;

namespace Geometria
{
    public class Definizioni
    {
    }
    namespace ConcettoPrimitivo
    {
        public class Punto
        {
            private List<Double> _Dimensions = new List<Double>();

            public Punto(Double x , Double y)
            {
                _Dimensions.Add(x);
                _Dimensions.Add(y);
            }

            public Double X
            {
                get { return this._Dimensions[0]; }
                set { this._Dimensions[0] = value; }
            }

            public Double Y
            {
                get { return this._Dimensions[1]; }
                set { this._Dimensions[1] = value; }
            }
        }

        public class Retta
        {
            public Retta(Double a ,Double b ,Double c)
            {

            }

            public Retta(Double m, Double q)
            {

            }
        }

        public class Semiretta
        {
            public Semiretta(Punto o , Punto v)
            {

            }
        }

        public class Segmento
        {
            public Segmento(Punto a, Punto b)
            {

            }
        }

        public class Poligonale
        {
            public Poligonale(List<Segmento> lineaSpezzata)
            {

            }
        }

    }

}
