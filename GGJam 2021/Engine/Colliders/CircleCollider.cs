using System;
using OpenTK;

namespace GGJam_2021 {
    class CircleCollider : Collider {
        public float Radius;

        public CircleCollider(Rigidbody owner, float radius) : base(owner) {
            Radius = radius;
        }

        public override void Scale(float scaleFactor) {
            Radius *= scaleFactor;
        }

        public override bool Collides(Collider other) {
            return other.Collides(this);
        }

        public override bool Collides(CompoundCollider compoundCollider) {
            return compoundCollider.Collides(this);
        }

        public override bool Collides(CircleCollider other) {
            Vector2 dist = other.Position - Position;
            return (dist.LengthSquared <= Math.Pow(other.Radius + Radius, 2));
        }

        public override bool Collides(BoxCollider box) {
            return box.Collides(this);
        }

        public override bool Contains(Vector2 point) {
            Vector2 distFromCenter = point - Position;
            return distFromCenter.LengthSquared <= (Radius * Radius);
        }
    }
}
