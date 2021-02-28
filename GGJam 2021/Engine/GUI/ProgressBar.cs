using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class ProgressBar : GameObject {
        protected Sprite barSprite;
        protected Texture barTexture;

        protected Vector2 barOffset;
        protected int barWidth;

        public override Vector2 Position {
            get => base.Position; set {
                base.Position = value;
                barSprite.position = value + barOffset;
            }
        }

        public ProgressBar(string frameTextureName, string barTextureName, Vector2 innerBarOffset) : base(frameTextureName, LayerMask.UI) {
            sprite.pivot = Vector2.Zero;
            IsActive = true;

            barOffset = innerBarOffset;

            barTexture = GfxManager.GetTexture(barTextureName);
            barSprite = new Sprite(barTexture.Width, barTexture.Height);
            barWidth = (int)barSprite.Width;
        }

        public override void Scale(float scale) {
            scale = MathHelper.Clamp(scale, 0, 1);

            barSprite.scale.X = scale;
            barWidth = (int)(barSprite.Width * scale);
        }

        public override void Draw() {
            if (IsActive) {
                base.Draw();
                barSprite.DrawTexture(barTexture, 0, 0, barWidth, (int)barSprite.Height);

            }
        }
    }
}
