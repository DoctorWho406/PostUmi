using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class GameObject {
        public Vector2 Position {
            get => sprite.position;
            set => sprite.position = value;
        }

        protected Sprite sprite;
        protected Texture texture;
        protected Vector2 size;
        protected Vector2 halfSize {
            get; private set;
        }
        protected bool isMoving;
        protected Vector2 speed;

        public GameObject(string textureName, Scene scene, bool isMoving/*, int w = 0, int h = 0*/) {
            this.isMoving = isMoving;
            texture = TextureManager.GetTexture(textureName);
            sprite = new Sprite(/*w == 0 ?*/ texture.Width /*: w, h == 0 ?*/, texture.Height /*: h*/);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
            SceneManager.AddGOToScene(scene, this);
        }

        public GameObject(int width, int height, Scene scene, bool isMoving) {
            this.isMoving = isMoving;
            sprite = new Sprite(width, height);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.5f);
            size = new Vector2(sprite.Width, sprite.Height);
            halfSize = new Vector2(size.X * 0.5f, size.Y * 0.5f);
            SceneManager.AddGOToScene(scene, this);
        }

        public virtual void Update() {
            if (isMoving) {
                sprite.position += speed * Game.DeltaTime;
            }
        }

        public virtual void Draw() {
            if (texture != null) {
                sprite.DrawTexture(texture);
            }
        }
    }
}
