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
        List<Particle> particles = new List<Particle>();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

        }

        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    particle.Life = 20 + Particle.rand.Next(100);
                    particle.Speed = 1 + Particle.rand.Next(10);
                    // добавил направление движения -90 градусов +-15
                    particle.Direction = -90 + 15 - Particle.rand.Next(30);
                    particle.Radius = 2 + Particle.rand.Next(10);
                    // генерировать вдоль верхней границы изображения
                    particle.X = Particle.rand.Next(picDisplay.Image.Width);
                    particle.Y = 0;
                }
                else
                {
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
                {
                    // снег белый, поэтому придется использовать ParticleColorful
                    var particle = ParticleImage.Generate();
                    particle.image = Properties.Resources.particle;


                    // координата X вдоль всей верхней границы может оказаться
                    particle.X = Particle.rand.Next(picDisplay.Image.Width);
                    particle.Y = 0;
                    // направление движения чтобы вниз
                    particle.Direction = -90 + 15 - Particle.rand.Next(30);
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }


            // функция рендеринга
            private void Render(Graphics g)
        {
            // утащили сюда отрисовку частиц
            foreach (var particle in particles)
            {
                particle.Draw(g);
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

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void PicDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}
