using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace частицы
{
    public partial class Form1 : Form
    {
        List<DirectionColorfulEmiter> emiters = new List<DirectionColorfulEmiter>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            // размещаем произвольным образом 10 эмитеров
            var rnd = new Random();
            for (var i = 0; i < 16; ++i)
            {
                emiters.Add(new DirectionColorfulEmiter
                {
                    ParticlesCount = 40,
                    Position = new Point(rnd.Next(picDisplay.Width), -20),
                    Radius = 2 + rnd.Next(5),
                });
            }
        }

        private void UpdateState()
        {
            foreach (var emiter in emiters)
            {
                emiter.UpdateState();
            }
        }


            // функция рендеринга
            private void Render(Graphics g)
        {
            foreach (var emiter in emiters)
            {
                emiter.Render(g);
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // А ЕЩЕ ЧЕРНЫЙ ФОН СДЕЛАЮ
                Render(g);
            }

            picDisplay.Invalidate();
        }

        

        private void PicDisplay_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void TbDirection_Scroll(object sender, EventArgs e)
        {
            foreach (var emiter in emiters)
            {
                emiter.Direction = tbDirection.Value;
            }
        }

        private void TbSpread_Scroll(object sender, EventArgs e)
        {
            foreach (var emiter in emiters)
            {
                emiter.Spread = tbSpread.Value;
            }
        }

        private void BtnFromColor_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // и тут
                foreach (var emiter in emiters)
                {
                    emiter.FromColor = dialog.Color;
                }
                btnFromColor.BackColor = dialog.Color;
            }
        }

        private void BtnToColor_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // и даже тут
                foreach (var emiter in emiters)
                {
                    emiter.ToColor = dialog.Color;
                }
                btnToColor.BackColor = dialog.Color;
            }
        }
    }
}
