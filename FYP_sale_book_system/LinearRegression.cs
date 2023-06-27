using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class LinearRegression
    {
        
            double a;
            double b;
            double yy;
            double xx;
            double SumX;
            double SumY;
            double MeanOfX;
            double MeanOfY;

            List<double> PersonX = new List<double>();// X - Mx
            List<double> PersonY = new List<double>();// Y - My

            double SX = 0; //Sum of (X - Mx)^2
            double SY = 0; //Sum of (X - Mx)(Y - My)


            double SSx;
            double SP;

            //Regression Equation = ŷ = bX + a
            //b = SP / SSx
            //a = MeanOfY - (b)(MeanOfX)
            //so Y = b X + a
            private double[] CalLinearRegression(List<double> x, List<double> y,int M) {
                this.SumX = x.Sum();
                this.SumY = y.Sum();
                this.MeanOfX = SumX / (x.Count());
                this.MeanOfY = SumY / (y.Count());
                double xMax = x.Max();
                double xMin = x.Min();
                double OutputY;
                double OutputX;
                double[] LocationXY = new double[2];
                CalPart1(x, y);//PersonX = X - Mx and PersonY = Y - My
                CalPart2();// (X - Mx)2
                CalPart3();//(X - Mx)(Y - My)
                SPSSX_b();//b = SP / SSx
                MYBMX_a();//a = MeanOfY - (b)(MeanOfX)
                if (M == 0)//XY MAX
                {
                    OutputY = this.b * xMax + this.a;
                    OutputX = xMax;
                    LocationXY[0] = OutputX;
                    LocationXY[1] = OutputY;
                    return LocationXY;

                }
                else { //XY MIN
                    OutputY = this.b * xMin + this.a;
                    OutputX = xMin;
                    LocationXY[0] = OutputX;
                    LocationXY[1] = OutputY;
                    return LocationXY;
                }
                return LocationXY;




            }
            private void CalPart1(List<double> targetX, List<double> targetY) {
                int size = targetX.Count();
                for (int x = 0; x <= size - 1; x++) {
                    PersonX.Add(targetX[x] - this.MeanOfX);
                    PersonY.Add(targetY[x] - this.MeanOfY);
                }
            }//PersonX = X - Mx and PersonY = Y - My

            private void CalPart2() {
                for (int x = 0; x <= this.PersonX.Count - 1; x++)
                {
                    this.SX = this.SX + (Math.Pow(this.PersonX[x], 2));//Base,power
                }
                this.SSx = this.SX;
            }// (X - Mx)2

            private void CalPart3() {
                for (int x = 0; x <= this.PersonX.Count - 1; x++) {
                    this.SY = this.SY + (this.PersonX[x] * this.PersonY[x]);
                }
                this.SP = this.SY;
            }//(X - Mx)(Y - My)

            private void SPSSX_b() {
                double result = this.SP / this.SSx;
                this.b = result;
            }//b = SP / SSx

            private void MYBMX_a() {
                double result = this.MeanOfY - (this.b * this.MeanOfX);
                this.a = result;
            }//a = MeanOfY - (b)(MeanOfX)

            public double[] OutPutMaxLocationXY(List<double> x, List<double> y) {
                double[] result = CalLinearRegression(x, y,0);
                return result;
            }
            public double[] OutPutMinLocationXY(List<double> x, List<double> y) {
                double[] result = CalLinearRegression(x, y,1);
                return result;
            }

           


        
    }
}
