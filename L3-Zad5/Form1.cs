using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NET_L3_Zad5_v2
{
    public partial class Form1 : Form
    {
        private const int PanelWidth = 2000;
        private const int PanelHeight = 500;
        private const int Scale = 10;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.ClientSize = new System.Drawing.Size(PanelWidth, PanelHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            IntPtr hdc = e.Graphics.GetHdc(); // Pobieramy kontekst urządzenia (hdc) do rysowania

            try
            {
                DrawSinusoid(hdc);
            }
            finally
            {
                e.Graphics.ReleaseHdc(hdc); // Zwolnienie kontekstu urządzenia
            }
        }

        private void DrawSinusoid(IntPtr hdc)
        {
            Pen pen = new Pen(System.Drawing.Color.Blue);

            float step = 0.1f;
            for (float x = 0; x <= PanelWidth; x += step)
            {
                float y = (float)(Math.Sin(x / Scale) * Scale + PanelHeight / 2);
                Win32API.SetPixel(hdc, (int)x, (int)y, System.Drawing.ColorTranslator.ToWin32(pen.Color));
            }

            pen.Dispose();
        }

    }
}
