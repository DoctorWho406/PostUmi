using OpenTK;

namespace GGJam_2021 {
    abstract class Collider {
        //Position relative to center 
        public Vector2 Position;

        protected Collider(Vector2 position) {
            Position = position;
        }

        public abstract bool Collides(BoxCollider box);

        public abstract bool Collides(CircleCollider circle);
    }
}
