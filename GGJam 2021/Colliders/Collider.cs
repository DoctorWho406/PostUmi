using OpenTK;

namespace GGJam_2021 {
    enum ColliderType {
        BoxCollider,
        CircleCollider,
        Count
    }

    abstract class Collider {
        //Position relative to center 
        public Vector2 Position;

        protected Collider() {
        }

        public abstract void Scale(float scaleFactory);

        public bool Collides(Collider collider) {
            if (collider is BoxCollider) {
                return Collides((BoxCollider)collider);
            } else {
                return Collides((CircleCollider)collider);
            }
        }

        protected abstract bool Collides(BoxCollider box);

        protected abstract bool Collides(CircleCollider circle);

        
    }
}
