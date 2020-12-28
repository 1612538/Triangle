using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class Diem
    {
        private double x;
        private double y;

        public Diem(double a, double b){
            x = a;
            y = b;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }

        public double Canh(Diem A)
        {
            return Math.Sqrt(Math.Pow(x - A.GetX(), 2) + Math.Pow(y - A.GetY(), 2));
        }
    }

    public class TamGiac
    {
        private Diem A;
        private Diem B;
        private Diem C;
        public TamGiac(Diem a, Diem b, Diem c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double ChuVi()
        {
            return A.Canh(B) + A.Canh(C) + B.Canh(C);
        }

        public int Loai()
        {
            double AB = A.Canh(B);
            double AC = A.Canh(C);
            double BC = B.Canh(C);
            if (AB == AC && AB == BC)
                return 1;
            else if ((AB * AB == AC * AC + BC * BC) || (AC * AC == AB * AB + BC * BC) || (BC * BC == AC * AC + AB * AB))
            {
                if (AB == AC || AB == BC || AC == BC)
                    return 2;
                else return 3;
            }
            else if (AB == AC || AB == BC || AC == BC)
                return 4;
            return 0;
        }
    }
}
