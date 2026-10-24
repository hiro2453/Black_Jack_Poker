using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BJ.Src
{
    public class OutlinedLabel : Label
    {
        [Category("表示")]
        [Description("縁取りの色を指定します。")]
        [DefaultValue(typeof(Color), "Black")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color StrokeColor { get; set; } = Color.Black;

        [Category("表示")]
        [Description("縁取りの太さを指定します。")]
        [DefaultValue(5f)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float StrokeWidth { get; set; } = 5f;

        public OutlinedLabel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(Text)) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 文字の描画領域を計算
            using (GraphicsPath path = new GraphicsPath())
            using (StringFormat sf = new StringFormat())
            {
                // テキストの配置設定（TextAlignプロパティに合わせる）
                SetStringFormatAlignment(sf);

                // EmSizeへの変換
                float emSize = e.Graphics.DpiY * Font.SizeInPoints / 72f;

                path.AddString(
                    Text,
                    Font.FontFamily,
                    (int)Font.Style,
                    emSize,
                    ClientRectangle,
                    sf
                );

                // 縁取り線を描画（線の中心がパスの境界線になるため、太さを2倍にして外側に出る量を確保します）
                if (StrokeWidth > 0)
                {
                    using (Pen pen = new Pen(StrokeColor, StrokeWidth * 2) { LineJoin = LineJoin.Round })
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                // 内側の塗りつぶし（縁取りの上に塗ることで、内側に食い込んだ線を隠します）
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private void SetStringFormatAlignment(StringFormat sf)
        {
            switch (TextAlign)
            {
                case ContentAlignment.TopLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
            }
        }
    }

    public class RotatableLabel : Control
    {
        private float angle = 0;
        private int opacity = 100; // 0〜100%
        private int scale = 100;    // 100 = 100%（100で標準サイズ、150で1.5倍）

        [Category("表示")]
        [Description("文字列の回転角度（度数法）を指定します。")]
        [DefaultValue(0f)]
        public float Angle
        {
            get => angle;
            set
            {
                angle = value;
                Invalidate();
            }
        }

        [Category("表示")]
        [Description("文字の不透明度をパーセントで指定します（0: 完全透明 〜 100: 完全不透明）。")]
        [DefaultValue(100)]
        public int Opacity
        {
            get => opacity;
            set
            {
                opacity = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }

        [Category("表示")]
        [Description("文字の拡大縮小率をパーセント整数で指定します（100 = 通常、150 = 1.5倍、200 = 2倍）。")]
        [DefaultValue(100)]
        public new int Scale
        {
            get => scale;
            set
            {
                // 0以下の値を防ぐため最小値を1%に制限
                scale = Math.Max(1, value);
                Invalidate();
            }
        }

        [Category("表示")]
        [Description("表示するテキストを指定します。")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        public RotatableLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw, true);

            Size = new Size(100, 100);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Text)) return;

            Graphics g = e.Graphics;

            // 高品質描画設定
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            using (GraphicsPath path = new GraphicsPath())
            {
                float emSize = g.DpiY * Font.SizeInPoints / 72f;

                path.AddString(
                    Text,
                    Font.FontFamily,
                    (int)Font.Style,
                    emSize,
                    new Point(0, 0),
                    StringFormat.GenericDefault
                );

                RectangleF bounds = path.GetBounds();

                // 1. コントロールの中心へ原点を移動
                float centerX = Width / 2f;
                float centerY = Height / 2f;
                g.TranslateTransform(centerX, centerY);

                // 2. 回転を適用
                g.RotateTransform(angle);

                // 3. 整数(パーセント)をfloatの倍率に換算して拡大縮小（例: 150 -> 1.5f）
                float scaleFactor = scale / 100f;
                g.ScaleTransform(scaleFactor, scaleFactor);

                // 4. 文字中心が原点(0,0)に重なるよう平行移動
                g.TranslateTransform(-(bounds.Left + bounds.Width / 2f), -(bounds.Top + bounds.Height / 2f));

                // 5. 不透明度を適用して描画
                int alpha = (int)Math.Round(opacity * 255f / 100f);
                Color textColor = Color.FromArgb(alpha, ForeColor);

                using (Brush brush = new SolidBrush(textColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }
    }
}
