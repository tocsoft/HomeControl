using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeControl
{
    public enum Rotation
    {
        Rotation0,
        Rotation90,
        Rotation180,
        Rotation270
    }

    public static class Orientation
    {
        private static Rotation rotation;
        public static EventHandler RotationChanged;
        public static Rotation Rotation
        {
            get
            {
                return rotation;
            }
            set
            {
                if (Rotation != value)
                {
                    rotation = value;
                    OnRotationChanged();
                }
            }
        }

        public static bool IsLandscape
        {
            get
            {
                return Rotation == Rotation.Rotation90
                    || Rotation == Rotation.Rotation270;
            }
        }

        private static void OnRotationChanged()
        {
            if (RotationChanged != null)
                RotationChanged(null, EventArgs.Empty);
        }
    }
}
