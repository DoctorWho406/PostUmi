using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class GameObject {
        protected Vector2 position {
            get => sprite.position;
            set => sprite.position = value;
        }
        protected Vector2 speed;
        protected Sprite sprite;
        protected Texture texture;

        //ctor

        public void Update() {
            sprite.position += speed * Game.DeltaTime;
        }

        public virtual void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
