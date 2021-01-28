using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    abstract class GameObject {
        protected Vector2 position {
            get => sprite.position;
            set => sprite.position = value;
        }
        protected Vector2 speed;
        protected Sprite sprite;
        protected Texture texture;

        protected GameObject(Vector2 position) {
            this.position = position;
        }

        public virtual void Update() {
            sprite.position += speed * Game.DeltaTime;
        }

        public virtual void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
