using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace MouseThingy
{
    static class MouseInput
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Vector2 lpPoint);

        private static Timer mouseUpdate;

        private static Vector2 oldMousePos;

        public static void Start()
        {
            GetCursorPos(out oldMousePos);

            mouseUpdate = new Timer(new TimerCallback(UpdateMouse), null, 0, 10);
        }

        private static void UpdateMouse(object thing)
        {
            Vector2 newMousePos;
            GetCursorPos(out newMousePos);
            Vector2 mouseDelta = newMousePos - oldMousePos;

            // Update halo view angle here

            oldMousePos = newMousePos;
        }
    }

    struct Vector2
    {
        public Vector2(int a, int b)
        {
            X = a;
            Y = b;
        }

        public int X;
        public int Y;

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }
    }
}
