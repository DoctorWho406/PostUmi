using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Aiv.Fast2D;

namespace GGJam_2021
{
    class Background
    {
        Texture texture;
        Sprite sprite;
        private Vector2 target;
        public Background()
        {
            texture = TextureManager.GetTexture("Background");
            sprite = new Sprite(texture.Width, texture.Height);
        }

        public void Draw()
        {
            sprite.DrawTexture(texture);
        }
    }
}
