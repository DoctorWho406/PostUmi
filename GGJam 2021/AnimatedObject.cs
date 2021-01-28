using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class AnimatedObject : GameObject {
        public Vector2 Size;

        private Animation animation;

        public override void Update() {
            base.Update();
            animation.Update();
        }

        public override void Draw() {
            sprite.DrawTexture(texture, (int)animation.Offset.X, (int)animation.Offset.Y, (int)Size.X, (int)Size.Y);
        }
    }
}
