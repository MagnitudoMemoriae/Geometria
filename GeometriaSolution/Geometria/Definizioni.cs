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

            private String _Hash = String.Empty;

            public Punto(Double x , Double y)
            {
                _Dimensions.Add(x);
                _Dimensions.Add(y);
                GetHash();
            }

            public Double X
            {
                get { return this._Dimensions[0]; }
                set { this._Dimensions[0] = value; GetHash(); }
            }

            public Double Y
            {
                get { return this._Dimensions[1]; }
                set { this._Dimensions[1] = value; GetHash(); }
            }

            private void  GetHash()
            {
                _Hash = GetHash(this); 
            }

            public static String GetHash(Punto punto)
            {
                return String.Format("{0}-{1}",punto.X , punto.Y); 
            }

            public String Hash
            {
                get { return this._Hash; }
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
            private Double _Lunghezza = 0;

            public Segmento(Punto a, Punto b)
            {

            }

            public Double Lunghezza
            {
                get { return this._Lunghezza; }
            }
        }


        public class Vettore : Segmento
        {
            public Vettore(Punto a, Punto b) : base(a, b)
            {
            }
        }

        public class Poligonale
        {
            protected List<Punto> _Punti = new List<Punto>();
            protected List<Segmento> _LineaSpezzata = new List<Segmento>();
            protected Boolean _IsPoligono = false;

            public Poligonale()
            {

            }

            public Poligonale(List<Segmento> lineaSpezzata)
            {
                this.Manage(lineaSpezzata);
            }

            public Poligonale(List<Punto> punti)
            {
                this.Manage(punti);
            }

            private List<Punto> GetPunti(List<Segmento> lineaSpezzata)
            {
                List<Punto> ReturnValue = new List<Punto>();



                return ReturnValue;
            }

            private List<Segmento> GetLineaSpezzataChiusa(List<Punto> lineaSpezzata)
            {
                List<Segmento> ReturnValue = new List<Segmento>();



                return ReturnValue;
            }

            private void Manage(List<Punto> punti)
            {

            }

            private void Manage(List<Segmento> lineaSpezzata)
            {

            }

            public List<Punto> Punti
            {
                get { return this._Punti; }
            }

            public List<Segmento> LineaSpezzataChiusa
            {
                get { return this._LineaSpezzata; }
            }

            public  Boolean IsPoligono
            {
                get { return this._IsPoligono; }
            }

        }

        public abstract class Poligono  
        {
            protected Poligonale _Poligonale = new Poligonale();

            protected abstract Double GetArea();

            public Poligono(Poligonale poligonale)
            {

            }



            protected Double _Area = 0;

            public Double Area
            {
                get { return this._Area; }
            }

            private Double _Perimetro = 0;

            public Double Perimetro
            {
                get { return this._Perimetro; }
            }

            public int NumeroLati
            {
                get { return this._Poligonale.Punti.Count; }
            }
        }

    }

}
