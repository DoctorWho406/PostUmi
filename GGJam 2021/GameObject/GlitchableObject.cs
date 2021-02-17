using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class GlitchableObject : GameObject {
        public override Vector2 Position {
            set {
                base.Position = value;
                spriteGlitch1.position = value;
                spriteGlitch2.position = value;
            }
        }

        protected Sprite spriteGlitch1, spriteGlitch2;
        protected bool glitch;
        protected float timer;
        protected bool glithched;

        public GlitchableObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, float fps = 0) : base(textureName, layerMask, w, h, fps) {
            spriteGlitch1 = new Sprite(sprite.Width, sprite.Height);
            spriteGlitch2 = new Sprite(sprite.Width, sprite.Height);

            spriteGlitch1.SetMultiplyTint(Constants.tintaBlue);
            spriteGlitch2.SetMultiplyTint(Constants.tintaGialla);

            spriteGlitch1.pivot = sprite.pivot;
            spriteGlitch2.pivot = sprite.pivot;

            StatsManager.AddGlitcableObject(this);
        }

        public override void Scale(float scaleFactory) {
            base.Scale(scaleFactory);
            spriteGlitch1.scale = new Vector2(scaleFactory);
            spriteGlitch2.scale = new Vector2(scaleFactory);
        }

        public virtual void SetGlitch(bool value) {
            glitch = value;
        }

        public bool GetGlitch() {
            return glitch;
        }

        public override void Update() {
            if (glitch) {
                timer += Game.DeltaTime;
                if (timer > Constants.GlitchTime) {
                    timer = 0f;
                    glithched = !glithched;
                }
            }
        }

        public override void Draw() {
            if (!glitch) {
                base.Draw();
            } else {
                if (glithched) {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                } else {
                    spriteGlitch2.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }
    }
}
