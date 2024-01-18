using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game5
{
    internal class Projectile
    {
        public Bullet bullet;

        public Projectile() { bullet = new Bullet(); }

        public class Bullet
        {
            public PictureBox PictureBox { get; set; }
            public int Damage { get; set; }

            public Bullet()
            {
           
            }

            public Bullet(PictureBox pictureBox, int damage)
            {
                PictureBox = pictureBox;
                Damage = damage;
            }
        }
    }
}
