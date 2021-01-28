using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class AnimatedObject : GameObject {
        public Vector2 Size;

        private Animation animation;

        public AnimatedObject(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60) : base(position) {
            Size = size;
            sprite = new Sprite(size.X, size.Y);
            animation = new Animation(this, rowsSpriteSheet, columnsSpriteSheet, fps);
        }

        public override void Update() {
            base.Update();
            animation.Update();
        }

        public override void Draw() {
            sprite.DrawTexture(texture, (int)animation.Offset.X, (int)animation.Offset.Y, (int)Size.X, (int)Size.Y);
        }
    }
}
