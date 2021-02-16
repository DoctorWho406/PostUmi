using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    enum LayerMask {
        Background,
        Middleground,
        Foreground,
        UI,
        Count
    }

    abstract class GameObject : IUpdatable, IDrawable {
        public bool IsActive;
        public virtual Vector2 Position {
            get => sprite.position;
            set {
                sprite.position = value;
                spriteGlitch1.position = value;
                spriteGlitch2.position = value;
            }
        }
        public LayerMask LayerMask;
        public Vector2 Size;
        public RigidBody RigidBody;

        protected Sprite sprite, spriteGlitch1, spriteGlitch2;
        protected Texture texture;
        protected Animation animation;
        protected Vector2 textureOffset;
        protected Vector2 halfSize {
            get; private set;
        }
        protected bool glitch;
        private float timer;
        protected bool glithched;

        public GameObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, float fps = 0) {
            //Set LayerMask
            LayerMask = layerMask;
            //Set Texture and Sprite
            texture = TextureManager.GetTexture(textureName);
            w = w == 0 ? texture.Width : w;
            h = h == 0 ? texture.Height : h;
            //Create Animation
            animation = new Animation(w , h, fps, texture.Width / w);
            textureOffset = Vector2.Zero;

            sprite = new Sprite(w, h);
            spriteGlitch1 = new Sprite(w, h);
            spriteGlitch2 = new Sprite(w, h);

            spriteGlitch1.SetMultiplyTint(Constants.tintaBlue);
            spriteGlitch2.SetMultiplyTint(Constants.tintaGialla);

            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            spriteGlitch1.pivot = sprite.pivot;
            spriteGlitch2.pivot = sprite.pivot;

            Size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(Size.X * 0.5f, Size.Y * 0.5f);
        }

        public virtual void Scale(float scaleFactory) {
            sprite.scale = new Vector2(scaleFactory);
            spriteGlitch1.scale = new Vector2(scaleFactory);
            spriteGlitch2.scale = new Vector2(scaleFactory);
            Size *= scaleFactory;
            halfSize *= scaleFactory;
        }

        public virtual void SetGlitch(bool value) {
            glitch = value;
        }

        public bool GetGlitch() {
            return glitch;
        }

        public virtual void Update() {
            if (glitch) {
                timer += Game.DeltaTime;
                if (timer > Constants.GlitchTime) {
                    timer = 0f;
                    glithched = !glithched;
                }
            }
        }

        public virtual void Draw() {
            if (!glitch) {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            } else {
                if (glithched) {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                } else {
                    spriteGlitch2.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }

        public virtual void OnCollide(GameObject other) {

        }
    }
}
