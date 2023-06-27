using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class Regression
    {
        private double[] x;
        private double[] y;
        private double[] xQ;
        private double[] yQ;
        private double[] xy;
        private double[] x2y;
        private double[] x4;
        private double[] x3;

        private void calSummary(string[] xx, string[] yy)
        {
            getArrayData(xx, yy);
            calQuadratic(x, 1);
            calQuadratic(y, 1);
            XY();
            calx2y();
            calx3();
            calx4();



        }

        private void calx2y()
        {

            int size = xQ.Length;
            x2y = new double[size];
            for (int z = 0; z <= size - 1; z++)
            {
                x2y[z] = xQ[z] * y[z];
            }
        }

        private void calx3()
        {
            int size = x.Length;


            x3 = new double[size];


            for (int z = 0; z <= size - 1; z++)
            {

                x3[z] = Math.Pow(x[z], 3);

            }
        }

        private void calx4()
        {
            int size = x.Length;


            x4 = new double[size];


            for (int z = 0; z <= size - 1; z++)
            {

                x4[z] = Math.Pow(x[z], 4);

            }
        }

        private void XY()
        {
            int size = x.Length;
            xy = new double[size];
            for (int z = 0; z <= size - 1; z++)
            {
                xy[z] = x[z] * y[z];
            }
        }
        private void calQuadratic(double[] value, int cQ)
        {
            int size = value.Length;
            if (cQ == 1)
            {
                xQ = new double[size];
            }
            else
            {
                yQ = new double[size];
            }
            for (int z = 0; z <= size - 1; z++)
            {
                if (cQ == 1)
                {
                    xQ[z] = Math.Pow(value[z], 2);
                }
                else
                {
                    yQ[z] = Math.Pow(value[z], 2);
                }

            }

        }
        private void getArrayData(string[] xx, string[] yy)
        {
            //y = ax^2 + Bx + C
            int xxsize = xx.Length;
            int yysize = yy.Length;
            x = new double[xxsize];
            y = new double[yysize];

            for (int z = 0; z <= xxsize - 1; z++)
            {
                if (xx[z].Length > 0)
                {
                    x[z] = Convert.ToDouble(0);
                }
                else
                {
                    x[z] = Convert.ToDouble(xx[z]);
                }

            }

            for (int z = 0; z <= yysize - 1; z++)
            {
                if (yy[z].Length > 0)
                {
                    y[z] = Convert.ToDouble(0);
                }
                else
                {
                    y[z] = Convert.ToDouble(yy[z]);
                }
            }


        }
    }

}
