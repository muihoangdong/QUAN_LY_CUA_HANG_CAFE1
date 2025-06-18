using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_CAFE1.LichTrinh
{
    public partial class lichtrinh : UserControl
    {
        public lichtrinh()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 595);
            this.panel2.TabIndex = 0;
            // 
            // lichtrinh
            // 
            this.Controls.Add(this.panel2);
            this.Name = "lichtrinh";
            this.Size = new System.Drawing.Size(975, 595);
            this.ResumeLayout(false);

        }
    }
}
