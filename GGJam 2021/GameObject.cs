using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    abstract class GameObject : Object {
        protected Vector2 speed;

        protected GameObject(Vector2 position) : base(position) {
        }

        public virtual void Update() {
            sprite.position += speed * Game.DeltaTime;
        }
    }
}
