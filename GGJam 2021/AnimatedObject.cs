using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class AnimatedObject : GameObject {
        public Vector2 Size;

        private Animation animation;

        public AnimatedObject(Texture texture) {
            animation = new Animation(this, 6, 7, 30);
            this.texture = texture;
            sprite = new Sprite(texture.Width / 7, texture.Height / 6);
        }

        public override void Draw() {
            sprite.DrawTexture(texture, (int)animation.Offset.X, (int)animation.Offset.Y, (int)Size.X, (int)Size.Y);
        }
    }
}
