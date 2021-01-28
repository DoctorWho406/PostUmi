using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class Object {
        protected Vector2 position {
            get => sprite.position;
            set => sprite.position = value;
        }
        protected Sprite sprite;
        protected Texture texture;

        protected Object(Vector2 position) {
            this.position = position;
        }

        public virtual void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
