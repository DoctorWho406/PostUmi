using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Aiv.Fast2D;

namespace GGJam_2021
{
    class Slider
    {
        private Sprite sprite;
        private Stat stat;

        public Slider(Vector2 position, Stat stat)
        {
            this.stat = stat;
            if (stat == Stat.FAME)
            {
                sprite = new Sprite(Constants.hungerMax, 50);
            }
            else if (stat == Stat.PARANOIA)
            {
                sprite = new Sprite(Constants.paranoiaMax, 50);
            }
            sprite.position = position;
        }

        public void Update()
        {
            sprite.scale = new Vector2(stat == Stat.PARANOIA ? Game.Player.paranoia : Game.Player.hunger, 1);
        }

        public void Draw()
        {
            sprite.DrawColor(new Vector4(255, 0, 0, 255));
        }
    }
}
