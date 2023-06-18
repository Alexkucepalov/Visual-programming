using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Vector3D
    {
        private double x, y, z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vector3D(double x = 0, double y = 0, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            Vector3D v = new Vector3D();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }

        public static Vector3D operator *(Vector3D v1, double scal)
        {
            Vector3D v = new Vector3D();
            v.x = v1.x * scal;
            v.y = v1.y * scal;
            v.z = v1.z * scal;
            return v;
        }

        public static double modul(Vector3D v)
        {
            double mod = 0;
            mod = Math.Sqrt(Math.Pow(v.x, 2.0) + Math.Pow(v.y, 2.0) + Math.Pow(v.z, 2.0));
            return mod;
        }

        public static Vector3D proectionDecart(Vector3D v)
        {
            return v;
        }

        public static Vector3D proectionCilindr(Vector3D v)
        {
            double r = Math.Sqrt(Math.Pow(v.x, 2.0) + Math.Pow(v.y, 2.0));
            double phi = Math.Atan2(v.y, v.x);
            v.x = Math.Round(r, 2);
            v.y = Math.Round(phi, 2);
            return v;
        }

    }
}
