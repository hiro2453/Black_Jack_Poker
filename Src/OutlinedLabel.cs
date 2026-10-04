using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
}
