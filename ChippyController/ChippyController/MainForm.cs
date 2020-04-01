using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyHooking;

namespace ChippyController
{
    public partial class MainForm : Form
    {
        private const float Sensitivty = 22.5F;
        private float radius;

        private int ScreenWidth;
        private int ScreenHeight;
        private PointF ScreenCenter;

        private int Counter;
        private Rotation Rotation;

        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            ScreenCenter = new PointF(ScreenWidth / 2.0f, ScreenHeight / 2.0f);

            radius = (float)Math.Sqrt(ScreenCenter.X * ScreenCenter.X + ScreenCenter.Y * ScreenCenter.Y);

            Counter = 0;
            Rotation = new Rotation(0);

            ScreenSizeLabel.Text = ScreenWidth + "X" + ScreenHeight;

            Cursor.Position = new Point(ScreenWidth - 10, ScreenHeight - 10);

            KeyHooker.Keybd_InitHook();
            KeyHooker.OnHookCallback += KeyHooker_OnHookCallback;
        }

        private void KeyHooker_OnHookCallback(Keys keys)
        {
            KeyName.Text = ++Counter + keys.ToString();

            if (keys == Keys.Oemcomma)
            {
                Rotation -= Sensitivty;
            }
            else if (keys == Keys.OemPeriod)
            {
                Rotation += Sensitivty;
            }

            Cursor.Position = new Point((int)(ScreenCenter.X + (radius * Math.Cos(Rotation.GetValue() * Math.PI / 180))), (int)(ScreenCenter.Y + (radius * Math.Sin(Rotation.GetValue() * Math.PI / 180))));
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            KeyHooker.Keybd_UnHook();
        }
    }
}
