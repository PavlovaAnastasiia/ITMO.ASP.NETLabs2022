using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1.Models
{
    //public class Circle
    //{
    //    public double St { get; set; }
    //    public string Name{
    //        get { return String.Format("\"Окружность с радиусом {0}\"", St); }
    //    }
    //    public Circle(double a) 
    //    { 
    //        St = a; 
    //    }
    //    public double Dlina{
    //        get{double p = 2 * Math.PI* St; 
    //            return p;
    //        }
    //    }
    //    public double Area
    //    { 
    //        get{ double sq = Math.PI * St * St; 
    //            return sq; 
    //        } 
    //    }
    //}
    public class Circle : Shape, IComparable<Circle>
    {
        public Circle(double a)
        { 
            St = a; 
        }
        override public string Name
            {
                get{ return String.Format("\"Окружность с радиусом {0}\"", St); 
                }
            }
        public double Dlina
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }
        public int CompareTo(Circle other) 
        { 
            if (this.Area == other.Area) 
                return 0; 
            else if(this.Area > other.Area) 
                return 1; 
            else return - 1; 
        }
    }
        public class Shape
        {
            public double St { get; set; }
            virtual public string Name
            {
                get
                {
                return String.Format("\"Фигура\"");
                }
            }
        }
}