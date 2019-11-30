using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChippyController
{
    class Rotation
    {
        private float r
        {
            get
            {
                return Rot;
            }
            set
            {
                if (value >= 360)
                {
                    Rot = value % 360;
                }
                else if (value < 0)
                {
                    Rot = 359 - (value * -1 % 360);
                }
                else
                {
                    Rot = value;
                }
            }
        }

        private float Rot;

        public Rotation(float Rot)
        {
            r = Rot;
        }

        public static Rotation operator +(Rotation a, Rotation b)
        {
            return new Rotation(a.Rot + b.Rot);
        }

        public static Rotation operator +(Rotation a, float b)
        {
            return new Rotation(a.Rot + b);
        }

        public static Rotation operator +(float a, Rotation b)
        {
            return new Rotation(a + b.Rot);
        }

        public static Rotation operator -(Rotation a, Rotation b)
        {
            return new Rotation(a.Rot - b.Rot);
        }

        public static Rotation operator -(Rotation a, float b)
        {
            return new Rotation(a.Rot - b);
        }

        public static Rotation operator -(float a, Rotation b)
        {
            return new Rotation(a - b.Rot);
        }

        public static bool operator ==(Rotation a, Rotation b)
        {
            return a.Rot == b.Rot;
        }

        public static bool operator !=(Rotation a, Rotation b)
        {
            return a.Rot != b.Rot;
        }

        public static bool operator <(Rotation a, Rotation b)
        {
            return a.Rot < b.Rot;
        }

        public static bool operator >(Rotation a, Rotation b)
        {
            return a.Rot > b.Rot;
        }

        public static bool operator <=(Rotation a, Rotation b)
        {
            return a.Rot <= b.Rot;
        }

        public static bool operator >=(Rotation a, Rotation b)
        {
            return a.Rot >= b.Rot;
        }

        public static bool operator ==(float a, Rotation b)
        {
            return a == b.Rot;
        }

        public static bool operator !=(float a, Rotation b)
        {
            return a != b.Rot;
        }

        public static bool operator <(float a, Rotation b)
        {
            return a < b.Rot;
        }

        public static bool operator >(float a, Rotation b)
        {
            return a > b.Rot;
        }

        public static bool operator <=(float a, Rotation b)
        {
            return a <= b.Rot;
        }

        public static bool operator >=(float a, Rotation b)
        {
            return a >= b.Rot;
        }

        public static bool operator ==(Rotation a, float b)
        {
            return a.Rot == b;
        }

        public static bool operator !=(Rotation a, float b)
        {
            return a.Rot != b;
        }

        public static bool operator <(Rotation a, float b)
        {
            return a.Rot < b;
        }

        public static bool operator >(Rotation a, float b)
        {
            return a.Rot > b;
        }

        public static bool operator <=(Rotation a, float b)
        {
            return a.Rot <= b;
        }

        public static bool operator >=(Rotation a, float b)
        {
            return a.Rot >= b;
        }

        public float GetValue()
        {
            return Rot;
        }

        public override bool Equals(object obj)
        {
            return obj is Rotation rotation &&
                   r == rotation.r &&
                   Rot == rotation.Rot;
        }

        public override int GetHashCode()
        {
            var hashCode = 1864569355;
            hashCode = hashCode * -1521134295 + r.GetHashCode();
            hashCode = hashCode * -1521134295 + Rot.GetHashCode();
            return hashCode;
        }
    }
}
