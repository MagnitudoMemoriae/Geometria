using Geometria.ConcettoPrimitivo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria.ConcettoPrimitivo.Poligoni
{


    //public class PoligonoRegolare : Poligono
    //{
    //    public PoligonoRegolare(List<Segmento> lati) : base(lati)
    //    {

    //    }

    //    public PoligonoRegolare(List<Punto> punti) : base(punti)
    //    {

    //    }
    //}

    public class Triangolo : Poligono
    {
        public Triangolo(List<Segmento> lati) : base(lati)
        {

        }

        public Triangolo(List<Punto> punti) : base(punti)
        {

        }

        protected override double GetArea()
        {
            throw new NotImplementedException();
        }

        protected override double GetPerimetro()
        {
            throw new NotImplementedException();
        }
    }

    public class TriangoloScaleno : Triangolo
    {
        public TriangoloScaleno(List<Segmento> lati) : base(lati)
        {

        }

        public TriangoloScaleno(List<Punto> punti) : base(punti)
        {

        }
    }

    public class TriangoloIsoscele : Triangolo
    {
        public TriangoloIsoscele(List<Segmento> lati) : base(lati)
        {

        }

        public TriangoloIsoscele(List<Punto> punti) : base(punti)
        {

        }
    }

    public class TriangoloEquilatero  : Triangolo
    {
        public TriangoloEquilatero(List<Segmento> lati) : base(lati)
        {

        }

        public TriangoloEquilatero(List<Punto> punti) : base(punti)
        {

        }
    }




}
