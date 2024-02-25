using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Equations_of_a_circle
{
    internal class Circle
    {
		private double radio;

		public double Radio
		{
			get { return radio; }
			set { radio = value; }
		}

		private double h;

		public double H
		{
			get { return h; }
			set { h = value; }
		}

		private double k;

		public double K
		{
			get { return k; }
			set { k = value; }
		}

		public Circle()
		{
				radio=0; h=0; k=0;
		}

        public Circle(double radio,double h,double k)
        {
			this.k = k;
			this.radio = radio;
			this.h = h;
        }

        //Receive-only method
        public void DisplayCircleInfo(Circle c)
        {
            Console.WriteLine("The equation and area of the circle with center: (" + c.H + "," + c.K + ")" + " and radio: " + c.Radio + "\nis: ");
        }

        //Method that only returns
        public string GetEquationOfTheCircle()
		{
			return "x²+y²= " +Math.Pow(radio,2);
		}

        //Method that returns and receives
        public string GetEquationOfTheCircle(double radio,double h, double k)
        {
            string signo = ((-1*h) >= 0) ? "+" : "-";
            string signo2 = ((-1*k) >= 0) ? "+" : "-";
            return "(x" + signo + Math.Abs(h) + ")²+" + "(y" + signo2 + Math.Abs(k) + ")²= " + Math.Pow(radio, 2);
        }

        //Overloaded method
        public string GetEquationOfTheCircle(Circle c)
        {
			double D = (-2)*c.h;
            string signo = (D >= 0) ? "+" : "-";
            double E = (-2)*c.k;
            string signo2 = (E >= 0) ? "+" : "-";
            double F = (Math.Pow(c.h,2))+ (Math.Pow(c.k, 2)-(Math.Pow(c.radio, 2)));
            return "x²+y²" + signo + Math.Abs(D) + "x" + signo2 + Math.Abs(E) + "y+"+F+"=0";
        }

        public void ShowEquationGral()
        {
            Console.WriteLine("And its general equation is:");
        }

        ~Circle()
        {
             Console.WriteLine("Object is being finalized. Cleaning up resources.");
        }
    }
}
