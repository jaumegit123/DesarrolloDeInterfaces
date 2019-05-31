using System;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Globalization;

namespace RelojAnalogico {
    //[ToolboxBitmap(typeof(Timer))]
    public partial class RelojAnalogico : UserControl {

        private float _radius;
        private PointF _center;
        BufferedGraphicsContext CurrentContext = BufferedGraphicsManager.Current;

        public RelojAnalogico() {
            InitializeComponent();
            _radius = (this.Width * .9f) / 2;
            _center = new PointF(this.Width / 2, this.Height / 2);
        }

        #region Métodos del reloj
        public void Start() {
            tmrAnalogClock.Enabled = true;
        }
        public void Stop() {
            tmrAnalogClock.Enabled = false;
        }
        #endregion Métodos del reloj

        #region Propiedades
        private Color _innercolor = Color.SkyBlue;
        public Color InnerColor {
            get { return _innercolor; }
            set { _innercolor = value; }
        }

        private Color _outercolor = Color.SteelBlue;
        public Color OuterColor {
            get { return _outercolor; }
            set { _outercolor = value; }
        }

        private Color _handcolor = Color.Black;
        public Color HandColor {
            get { return _handcolor; }
            set { _handcolor = value; }
        }

        private Color _secondhandcolor = Color.Red;
        public Color SecondHandColor {
            get { return _secondhandcolor; }
            set { _secondhandcolor = value; }
        }

        private Color _tickcolor = Color.Black;
        public Color TickColor {
            get { return _tickcolor; }
            set { _tickcolor = value; }
        }

        private Color _textcolor = Color.Black;
        public Color TextColor {
            get { return _textcolor; }
            set { _textcolor = value; }
        }

        public new bool Enabled {
            get { return tmrAnalogClock.Enabled; }
            set { tmrAnalogClock.Enabled = value; }
        }
        #endregion Propiedades

        #region Métodos Draw
        private void DrawBackground(Graphics g) {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(_center.X - _radius, _center.Y - _radius, _radius * 2, _radius * 2);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = _innercolor;
            pgb.SurroundColors = new Color[] { _outercolor };
            g.FillEllipse(pgb, _center.X - _radius, _center.Y - _radius, _radius * 2, _radius * 2);
            g.DrawEllipse(new Pen(_tickcolor, _radius * .01f), _center.X - _radius, _center.Y - _radius, _radius * 2, _radius * 2);
        }

        private void DrawTicks(Graphics g) {

            for (int i = 0; i < 4; i++)
                g.DrawLine(new Pen(_tickcolor, _radius * .05f),
                    (float)Math.Cos(i * 90 * Math.PI / 180) * _radius * .9f + _center.X,
                    (float)Math.Sin(i * 90 * Math.PI / 180) * _radius * .9f + _center.Y,
                    (float)Math.Cos(i * 90 * Math.PI / 180) * _radius + _center.X,
                    (float)Math.Sin(i * 90 * Math.PI / 180) * _radius + _center.Y);

            for (int i = 0; i < 12; i++)
                if (i % 3 != 0)
                    g.DrawLine(new Pen(_tickcolor, _radius * .03f),
                        (float)Math.Cos(i * 30 * Math.PI / 180) * _radius * .9f + _center.X,
                        (float)Math.Sin(i * 30 * Math.PI / 180) * _radius * .9f + _center.Y,
                        (float)Math.Cos(i * 30 * Math.PI / 180) * _radius + _center.X,
                        (float)Math.Sin(i * 30 * Math.PI / 180) * _radius + _center.Y);

            for (int i = 0; i < 60; i++)
                if (i % 5 != 0)
                    g.DrawLine(new Pen(_tickcolor, _radius * .01f),
                        (float)Math.Cos(i * 6 * Math.PI / 180) * _radius * .95f + _center.X,
                        (float)Math.Sin(i * 6 * Math.PI / 180) * _radius * .95f + _center.Y,
                        (float)Math.Cos(i * 6 * Math.PI / 180) * _radius + _center.X,
                        (float)Math.Sin(i * 6 * Math.PI / 180) * _radius + _center.Y);
        }

        private void DrawNumbers(Graphics g) {

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            for (int i = 1; i <= 12; i++)
                switch (i) {
                    case 10:
                        g.DrawString(i.ToString(), new Font("Tahoma", _radius * .15f, FontStyle.Bold), new SolidBrush(_textcolor),
                            (float)Math.Sin(i * 30 * Math.PI / 180) * _radius * .72f + _center.X,
                            (float)-Math.Cos(i * 30 * Math.PI / 180) * _radius * .8f + _center.Y, sf);
                        break;
                    case 11:
                        g.DrawString(i.ToString(), new Font("Tahoma", _radius * .15f, FontStyle.Bold), new SolidBrush(_textcolor),
                            (float)Math.Sin(i * 30 * Math.PI / 180) * _radius * .64f + _center.X,
                            (float)-Math.Cos(i * 30 * Math.PI / 180) * _radius * .8f + _center.Y, sf);
                        break;
                    default:
                        g.DrawString(i.ToString(), new Font("Tahoma", _radius * .15f, FontStyle.Bold), new SolidBrush(_textcolor),
                            (float)Math.Sin(i * 30 * Math.PI / 180) * _radius * .8f + _center.X,
                            (float)-Math.Cos(i * 30 * Math.PI / 180) * _radius * .8f + _center.Y, sf);
                        break;
                }
        }

        private void DrawHands(Graphics g) {
            int hour = DateTime.Now.Hour % 12;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            g.DrawLine(new Pen(_handcolor, _radius * .05f),
                _center.X - (float)(Math.Sin((hour * 30 + minute / 12 * 6) * Math.PI / 180)) * _radius * .1f,
                _center.Y - (float)(-Math.Cos((hour * 30 + minute / 12 * 6) * Math.PI / 180)) * _radius * .1f,
                (float)(Math.Sin((hour * 30 + minute / 12 * 6) * Math.PI / 180)) * _radius * .5f + _center.X,
                (float)(-Math.Cos((hour * 30 + minute / 12 * 6) * Math.PI / 180)) * _radius * .5f + _center.Y);
            g.DrawLine(new Pen(_handcolor, _radius * .03f),
                _center.X - (float)(Math.Sin(minute * 6 * Math.PI / 180)) * _radius * .1f,
                _center.Y - (float)(-Math.Cos(minute * 6 * Math.PI / 180)) * _radius * .1f,
                (float)(Math.Sin(minute * 6 * Math.PI / 180)) * _radius * .7f + _center.X,
                (float)(-Math.Cos(minute * 6 * Math.PI / 180)) * _radius * .7f + _center.Y);
            g.FillEllipse(new SolidBrush(_handcolor), _center.X - _radius * .05f, _center.Y - _radius * .05f, _radius * .1f, _radius * .1f);

            g.DrawLine(new Pen(_secondhandcolor, _radius * .01f),
                _center.X - (float)(Math.Sin(second * 6 * Math.PI / 180)) * _radius * .2f,
                _center.Y - (float)(-Math.Cos(second * 6 * Math.PI / 180)) * _radius * .2f,
                (float)(Math.Sin(second * 6 * Math.PI / 180)) * _radius * .9f + _center.X,
                (float)(-Math.Cos(second * 6 * Math.PI / 180)) * _radius * .9f + _center.Y);
            g.FillEllipse(new SolidBrush(_secondhandcolor), _center.X - _radius * .03f, _center.Y - _radius * .03f, _radius * .06f, _radius * .06f);
        }
        #endregion Métodos Draw

        private void tmrAnalogClock_Tick(object sender, EventArgs e) {
            BufferedGraphics bg = CurrentContext.Allocate(this.CreateGraphics(), this.ClientRectangle);
            bg.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            bg.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            bg.Graphics.Clear(this.BackColor);

            this.DrawBackground(bg.Graphics);

            this.DrawTicks(bg.Graphics);

            this.DrawNumbers(bg.Graphics);

            this.DrawHands(bg.Graphics);

            bg.Render();

            bg.Dispose();
        }

        private void AnalogClock_Resize(object sender, EventArgs e) {
            if (this.Width < this.Height)
                _radius = (this.Width * .9f) / 2;
            else
                _radius = (this.Height * .9f) / 2;
            _center = new PointF((float)this.Width / 2, (float)this.Height / 2);
            this.Refresh();
        }
    }
}