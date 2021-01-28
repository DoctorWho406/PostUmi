using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class AnimatedObject : GameObject {
        public Vector2 Size;

        private Animation animation;

        public AnimatedObject(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60) : base(position) {
            Size = size;
            sprite = new Sprite(size.X, size.Y);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            this.position = position;
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
