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
        private const int Sensitivty = 10;

        private int ScreenWidth;
        private int ScreenHeight;
        private PointF ScreenCenter;

        private int Counter;
        private Rotation Rotation;

        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            ScreenWidth = SystemInformation.VirtualScreen.Width;
            ScreenHeight = SystemInformation.VirtualScreen.Height;
            ScreenCenter = new PointF(ScreenWidth / 2.0f, ScreenHeight / 2.0f);

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

            Cursor.Position = new Point((int)(ScreenCenter.X + (ScreenCenter.Y * Math.Cos(Rotation.GetValue() * Math.PI / 180))), (int)(ScreenCenter.Y + (ScreenCenter.Y * Math.Sin(Rotation.GetValue() * Math.PI / 180))));
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            KeyHooker.Keybd_UnHook();
        }
    }
}
