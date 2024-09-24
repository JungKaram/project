using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeManagementVideo.AllUserContorls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(94, 398);
                labelBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(166, 398);
                labelBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(268, 398);
                labelBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
