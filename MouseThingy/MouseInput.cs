using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseThingy
{
    static class MouseInput
    {
        

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Vector2 lpPoint);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X,int Y);

        private static System.Threading.Timer mouseUpdate;

        private static Vector2 oldMousePos;

        private static Form1 _f;

        public static void Start(Form1 f)
        {
            _f = f;
            GetCursorPos(out oldMousePos);

            mouseUpdate = new System.Threading.Timer(new TimerCallback(UpdateMouse), null, 0, 1);
        }

        private static void UpdateMouse(object thing)
        {

            Vector2 newMousePos;
            GetCursorPos(out newMousePos);
            Vector2 mouseDelta = newMousePos - oldMousePos;
            
            // Update halo view angle here
            float hmul;
            if (_f.GetHMul(out hmul))
            {
                float h_delta = mouseDelta.X * hmul;

                byte[] temp = new byte[4];
                uint h_addr;
                if (_f.GetHAddr(out h_addr))
                {
                    HaloMemoryWriter.ReadFromMemory(h_addr, temp);
                    float h_prev = BitConverter.ToSingle(temp, 0);
                    h_prev -= h_delta;
                    h_prev = h_prev % (float)(2 * Math.PI);
                    temp = BitConverter.GetBytes(h_prev);
                    HaloMemoryWriter.WriteToMemory(h_addr, temp);
                }
            }

            float vmul;
            if (_f.GetVMul(out vmul))
            {
                float v_delta = mouseDelta.Y * -vmul;

                byte[] temp = new byte[4];
                uint v_addr;
                if (_f.GetVAddr(out v_addr))
                {
                    HaloMemoryWriter.ReadFromMemory(v_addr, temp);
                    float v_prev = BitConverter.ToSingle(temp, 0);
                    v_prev += v_delta;
                    v_prev = (float)(((v_prev + (Math.PI / 2)) % Math.PI) - (Math.PI / 2));
                    temp = BitConverter.GetBytes(v_prev);
                    HaloMemoryWriter.WriteToMemory(v_addr, temp);
                }
            }

            oldMousePos = newMousePos;

            SetCursorPos(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);

            oldMousePos = new Vector2(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
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
