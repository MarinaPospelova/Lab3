using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    class Flight
    {
        public double a;
        public double v0;
        public double y0;
        public double S;
        public double m;
        public double k;

        public double t;
        public double x;
        public double y;
        public double vx;
        public double vy;

        const double dt = 0.01;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        public void TakeValues(decimal Angle, decimal Speed, decimal Height, decimal Weight, decimal Square)
        {
            a = (double)Angle;
            v0 = (double)Speed;
            y0 = (double)Height;
            m = (double)Weight;
            S = (double)Square;
        }

        public void StartValues()
        {
            vx = v0 * Math.Cos(a * Math.PI / 180);
            vy = v0 * Math.Sin(a * Math.PI / 180);
            t = 0;
            x = 0;
            y = y0;
        }

        public void Calculation(double S, double m)
        {
            k = 0.5 * C * S * rho / m;
            vx = vx - k * vx * Math.Sqrt(vx * vx + vy * vy) * dt;
            vy = vy - (g + k * vy * Math.Sqrt(vx * vx + vy * vy)) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
        }
    }
}
