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

            public Punto(Double x, Double y)
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

            private void GetHash()
            {
                _Hash = GetHash(this);
            }

            public static String GetHash(Punto punto)
            {
                return String.Format("{0}-{1}", punto.X, punto.Y);
            }

            public String Hash
            {
                get { return this._Hash; }
            }
        }

        public class Retta
        {
            private Double _a;
            private Double _b;
            private Double _c;


            public Retta(Double a, Double b, Double c)
            {
                this._a = a;
                this._b = b;
                this._c = c;
            }

            public Retta(Double m, Double q)
            {
                this._a = -m;
                this._b = -q;
            }

            public Double A
            {
                get { return this._a; }
            }
        
            public Double B
            {
                get { return this._b; }
            }

            public Double C
            {
                get { return this._c; }
            }

            public Double M
            {
                get
                {

                    return -this._a;
                }
            }

            public Double Q
            {
                get
                {

                    return -this._b;
                }
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

            private Punto _A;
            private Punto _B;

            public Segmento(Punto a, Punto b)
            {
                _A = a;
                _B = b;
                Double DiffX = _B.X - _A.X;
                Double DiffY = _B.Y - _A.Y;

                Double AbsDiffX = Math.Abs(DiffX);
                Double AbsDiffY = Math.Abs(DiffY);

                Double QuareAbsDiffX = Math.Pow(AbsDiffX,2);
                Double QuareAbsDiffY = Math.Pow(AbsDiffY,2);

                Double SumQuareAbsDiff = QuareAbsDiffX + QuareAbsDiffY;

                Double SquareRootSumQuareAbsDiff = Math.Sqrt(SumQuareAbsDiff);

                _Lunghezza = SquareRootSumQuareAbsDiff;

            }

            public Punto A
            {
                get { return _A; }
            }

            public Punto B
            {
                get { return _B; }
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

        public enum LineaSpezzataTipo
        {
            NONDEFINITA,
            APERTASEMPLICE,
            APERTAINTRECCIATA,
            CHIUSASEMPLICE,
            CHIUSAINTRECCIATA
        }


        public class LineaSpezzata
        {
            private LineaSpezzataTipo _Tipo = LineaSpezzataTipo.NONDEFINITA;
            protected List<Punto> _Punti = new List<Punto>();
            protected List<Segmento> _Segmenti = new List<Segmento>();


            public LineaSpezzata()
            {

            }

            public LineaSpezzata(List<Punto> punti)
            {
                if(punti.Count >= 2)
                {
                    _Punti.AddRange(punti);

                    for (int iPunti = 0; iPunti < _Punti.Count - 1; iPunti++)
                    {
                        _Segmenti.Add(new Segmento(_Punti[iPunti], _Punti[iPunti + 1]));
                    }
                    if (_Punti.Count > 2)
                    {
                        _Segmenti.Add(new Segmento(_Punti[_Punti.Count - 2], _Punti[_Punti.Count - 1]));
                    }
                }

                // https://www.geeksforgeeks.org/check-if-two-given-line-segments-intersect/
            }

            public LineaSpezzata(List<Segmento> segmenti)
            {
                if (segmenti.Count >= 1)
                {
                    _Segmenti.AddRange(segmenti);

                    for (int iSegmenti = 0; iSegmenti < segmenti.Count ; iSegmenti++)
                    {
                        _Punti.Add(segmenti[iSegmenti].A);
                    }
                    _Punti.Add(segmenti[segmenti.Count -1].A);
                }
            }


            public LineaSpezzataTipo Tipo
            {
                get { return this._Tipo; }
            }

            public int Count
            {
                get { return this._Segmenti.Count; }
            }
        }

        public class Poligonale
        {
            protected List<Punto> _Punti = new List<Punto>();
            protected LineaSpezzata _LineaSpezzata = new LineaSpezzata();
            protected Boolean _IsPoligono = false;

            public Poligonale()
            {

            }

            public Poligonale(LineaSpezzata lineaSpezzata)
            {
                this.Manage(lineaSpezzata);
            }

            public Poligonale(List<Punto> punti)
            {
                this.Manage(punti);
            }

            private List<Punto> GetPunti(LineaSpezzata lineaSpezzata)
            {
                List<Punto> ReturnValue = new List<Punto>();

                for (int iLinea = 0; iLinea < lineaSpezzata.Count; iLinea++)
                {

                }

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

            private void Manage(LineaSpezzata lineaSpezzata)
            {

            }

            public List<Punto> Punti
            {
                get { return this._Punti; }
            }

            public LineaSpezzata lineaSpezzata
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

            public Poligono(Poligonale poligonale)
            {
                _Poligonale = poligonale;

                _Perimetro = 0;
                for (int iLato = 0; iLato < poligonale.LineaSpezzataChiusa.Count; iLato++)
                {
                    _Perimetro += poligonale.LineaSpezzataChiusa[iLato].Lunghezza;
                }

                this._Area = GetArea();
            }

            // Return the polygon's area in "square units."
            // The value will be negative if the polygon is
            // oriented clockwise.
            private Double GetArea()
            {

                Double ReturnValue = 0;
                // Add the first point to the end.
                List<Punto> punti = new List<Punto>();
                punti.AddRange(_Poligonale.Punti);
                punti.Add(_Poligonale.Punti[0]);

                // Get the areas.
                
                for (int i = 0; i < _Poligonale.Punti.Count; i++)
                {
                    ReturnValue +=
                        (punti[i + 1].X - punti[i].X) *
                        (punti[i + 1].Y + punti[i].Y) / 2;
                }

                // Return the result.
                return ReturnValue;
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
