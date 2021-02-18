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
        public virtual bool IsActive {
            get; set;
        }
        public virtual Vector2 Position {
            get => sprite.position;
            set => sprite.position = value;
        }
        public Vector2 HalfSize {
            get; private set;
        }
        public Rigidbody Rigidbody;
        public LayerMask LayerMask;

        protected Texture texture;
        protected Sprite sprite;
        protected Vector2 size;
        protected Animation animation;
        protected Vector2 textureOffset;

        public GameObject(string textureName, LayerMask layerMask, int w = 0, int h = 0, float fps = 0) {
            //Set LayerMask
            LayerMask = layerMask;
            //Set Texture and Sprite
            texture = TextureManager.GetTexture(textureName);
            w = w == 0 ? texture.Width : w;
            h = h == 0 ? texture.Height : h;
            //Create Animation
            animation = new Animation(w, h, fps, texture.Width / w, false);
            textureOffset = Vector2.Zero;

            sprite = new Sprite(w, h);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);

            size = sprite.pivot * 2f;
            HalfSize = sprite.pivot;
        }

        public virtual void Scale(float scaleFactor) {
            sprite.scale = new Vector2(scaleFactor);
            HalfSize *= scaleFactor;
            size *= scaleFactor;
            if (Rigidbody != null && Rigidbody.Collider != null) {
                Rigidbody.Collider.Scale(scaleFactor);
            }
        }

        public virtual void OnCollide(GameObject other) {

        }

        public virtual void Update() {
            if (IsActive) {
                animation.Update(ref textureOffset);
            }
        }

        public virtual void Draw() {
            if (IsActive) {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            }
        }
    }
}
