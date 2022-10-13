using OpenTK;

namespace GGJam_2021 {
    abstract class Collider {
        public Vector2 Offset;

        public Vector2 Position => Rigidbody.Position + Offset;

        public Rigidbody Rigidbody;

        public Collider(Rigidbody owner) {
            Rigidbody = owner;
            Offset = Vector2.Zero;
        }

        public virtual void Scale(float scaleFactor) {
            Offset *= scaleFactor;
        }

        public abstract bool Collides(Collider other);
        public abstract bool Collides(CompoundCollider compoundCollider);
        public abstract bool Collides(CircleCollider circle);
        public abstract bool Collides(BoxCollider box);
        public abstract bool Contains(Vector2 point);
    }
}
