using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace GGJam_2021 {
    class Player : AnimatedObject{
        public Player(Vector2 position, Vector2 size, int rowsSpriteSheet, int columnsSpriteSheet, int fps) : base(position, size, rowsSpriteSheet, columnsSpriteSheet, fps) {
            texture = TextureManager.GetTexture("Player");
        }

        public void Input() {
            if(Game.Window.)
        }

    }
}
