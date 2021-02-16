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
            set => sprite.position = value;
        }
        public Vector2 halfSize {
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
            animation = new Animation(w, h, fps, texture.Width / w);
            textureOffset = Vector2.Zero;

            sprite = new Sprite(w, h);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);

            size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
        }

        public virtual void Scale(float scaleFactory) {
            sprite.scale = new Vector2(scaleFactory);
            size *= scaleFactory;
            halfSize *= scaleFactory;
        }

        public virtual void OnCollide(GameObject other) {

        }

        public virtual void Update() {

        }

        public virtual void Draw() {
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
        }
    }
}
