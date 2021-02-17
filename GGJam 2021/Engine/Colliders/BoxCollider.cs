using System;
using OpenTK;

namespace GGJam_2021 {
    class BoxCollider : Collider {
        public Vector2 Size => halfSize * 2;

        protected Vector2 halfSize;

        public BoxCollider(Rigidbody owner, Vector2 halfSize) : base(owner) {
            this.halfSize = halfSize;
        }

        public override void Scale(float scaleFactor) {
            halfSize *= scaleFactor;
        }

        public override bool Collides(Collider collider) {
            return collider.Collides(this);
        }

        public override bool Collides(CompoundCollider compoundCollider) {
            return compoundCollider.Collides(this);
        }

        public override bool Collides(CircleCollider circle) {
            float deltaX = circle.Position.X - Math.Max(Position.X - halfSize.X, Math.Min(circle.Position.X, Position.X + halfSize.X));
            float deltaY = circle.Position.Y - Math.Max(Position.Y - halfSize.Y, Math.Min(circle.Position.Y, Position.Y + halfSize.Y));
            return (deltaX * deltaX + deltaY * deltaY) <= (circle.Radius * circle.Radius);
        }

        public override bool Collides(BoxCollider box) {
            float deltaX = box.Position.X - Position.X;
            float deltaY = box.Position.Y - Position.Y;
            return (Math.Abs(deltaX) <= halfSize.X + box.halfSize.X)
                && (Math.Abs(deltaY) <= halfSize.Y + box.halfSize.Y);
        }

        public override bool Contains(Vector2 point) {
            return point.X >= Position.X - halfSize.X
                && point.X <= Position.X + halfSize.X
                && point.Y >= Position.Y - halfSize.Y
                && point.Y <= Position.Y + halfSize.Y;
        }
    }
}
