using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGuitar
{
    public partial class LoadAnimation : UserControl
    {
        List<Color> colors = new List<Color>();
        int cur_color = 0;
        public LoadAnimation()
        {
            InitializeComponent();
            colors.Add(Color.FromArgb(255, 128, 0));
            colors.Add(Color.FromArgb(153, 255, 51));
            colors.Add(Color.FromArgb(255, 0, 127));
            colors.Add(Color.FromArgb(51, 255, 255));
            colors.Add(Color.FromArgb(255, 0, 0));
            colors.Add(Color.FromArgb(0, 0, 0));
            bunifuCircleProgressbar1.ProgressColor = colors[cur_color];
        }

        int dir = 1;
        private void Stretch_Tick(object sender, EventArgs e)
        {
            if(bunifuCircleProgressbar1.Value == 70)
            {
                dir = -1;
                bunifuCircleProgressbar1.animationSpeed = 2;
            }else if(bunifuCircleProgressbar1.Value == 30)
            {
                dir = +1;
                bunifuCircleProgressbar1.animationSpeed = 1;
            }
            bunifuCircleProgressbar1.Value += dir;
        }
        void randomColor()
        {
            bunifuColorTransition1.Color1 = colors[cur_color];
            if(cur_color < colors.Count - 1)
            {
                cur_color++;
            }else
            {
                cur_color = 0;
            }

            bunifuColorTransition1.Color1 = colors[cur_color];
            colortrans.Start();

        }

        private void Colortrans_Tick(object sender, EventArgs e)
        {
            if(bunifuColorTransition1.ProgessValue < 0)
            {

            }
        }
    }
}
