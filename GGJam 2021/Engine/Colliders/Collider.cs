using OpenTK;

namespace GGJam_2021 {
    abstract class Collider {
        public Vector2 Offset;

        public Vector2 Position => RigidBody.Position + Offset;

        public RigidBody RigidBody;

        public Collider(RigidBody owner) {
            RigidBody = owner;
            Offset = Vector2.Zero;
        }

        public abstract bool Collides(Collider collider);
        public abstract bool Collides(BoxCollider collider);
        public abstract bool Collides(CircleCollider circle);
        public abstract bool Contains(Vector2 point);
    }
}
