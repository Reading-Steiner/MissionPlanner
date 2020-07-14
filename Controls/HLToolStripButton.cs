using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class HLToolStripButton : ToolStripButton
    {
        public HLToolStripButton()
            : base() { }
        public HLToolStripButton(string text)
            : base(text) { }
        public HLToolStripButton(string text, Image image)
            : base(text, image) { }
        public HLToolStripButton(string text, Image image, EventHandler onClick)
            : base(text, image, onClick) { }
        public HLToolStripButton(string text, Image image, EventHandler onClick, string name)
            : base(text, image, onClick, name) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.MyChecked)
            {
                Graphics g = e.Graphics;
                int left = this.ContentRectangle.Left;
                int top = this.ContentRectangle.Top;
                int width = this.ContentRectangle.Width;
                int height = this.ContentRectangle.Height;
                float deltaHeight = 1;
                g.Clear(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < height; i++)
                {

                    Color brushColor = Color.FromArgb(
                        (int)(Math.Pow(2, ((double)i * (topColor - bottomColor)) / height + bottomColor) - 1), 
                        checkedbackgroundColor.R, 
                        checkedbackgroundColor.G, 
                        checkedbackgroundColor.B);
                    SolidBrush opcBrush = new SolidBrush(brushColor);

                    g.FillRectangle(opcBrush, left, top + i * deltaHeight, width, 1);
                }
                g.DrawImage(this.Image, this.ContentRectangle);

            }
            
        }

        private Color checkedbackgroundColor = Color.FromArgb(255, 255, 128, 0);
        [Category("设置"), Description("背景颜色底色")]
        public Color HightLightBackgroundColor
        {
            get { return checkedbackgroundColor; }
            set {
                checkedbackgroundColor = value;
                Invalidate();
            }
        }

        private int topColor = 8;
        [Category("设置"), Description("背景色上限")]
        public int TopTransparent
        {
            get { return topColor; }
            set
            {
                if (value >= 8)
                    topColor = 8;
                if (value <= 0)
                    topColor = 0;
                else
                    topColor = value;
                Invalidate();
            }
        }
        private int bottomColor = 0;
        [Category("设置"), Description("背景色下限")]
        public int BottomTransparent
        {
            get { return bottomColor; }
            set {
                if (value >= 8)
                    bottomColor = 8;
                if (value <= 0)
                    bottomColor = 0;
                else
                    bottomColor = value;
                Invalidate();
            }
        }

        [Category("设置"), Description("是否被选中")]
        public bool MyChecked
        {
            get { return this.Checked; }
            set
            {
                this.Checked = value;
                Invalidate();
            }

        }
    }
}
