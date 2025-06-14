using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_CAFE1.TrangChu
{
    public partial class trangchu : Form
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();


        public trangchu()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            SaveOriginalBounds(this);
        }

        public void loadAll()
        {
            originalFormSize = this.Size;
            SaveOriginalBounds(this);
        }

        private void SaveOriginalBounds(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                originalControlBounds[c] = c.Bounds;
                originalFontSizes[c] = c.Font.Size; // Lưu font size ban đầu

                if (c.HasChildren)
                    SaveOriginalBounds(c);
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;
            ResizeControls(this, xRatio, yRatio);
        }

        private void ResizeControls(Control parent, float xRatio, float yRatio)
        {
            foreach (Control c in parent.Controls)
            {
                if (originalControlBounds.ContainsKey(c))
                {
                    Rectangle original = originalControlBounds[c];
                    c.Left = (int)(original.Left * xRatio);
                    c.Top = (int)(original.Top * yRatio);
                    c.Width = (int)(original.Width * xRatio);
                    c.Height = (int)(original.Height * yRatio);

                    // Resize font đúng cách từ font gốc đã lưu
                    if (originalFontSizes.ContainsKey(c))
                    {
                        float originalFontSize = originalFontSizes[c];
                        c.Font = new Font(c.Font.FontFamily, originalFontSize * Math.Min(xRatio, yRatio), c.Font.Style);
                    }
                }

                // 🔁 Gọi đệ quy cho control con
                if (c.HasChildren)
                {
                    ResizeControls(c, xRatio, yRatio);
                }
            }
        }
    }
}
