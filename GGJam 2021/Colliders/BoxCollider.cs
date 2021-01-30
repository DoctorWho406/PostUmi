using System;
using OpenTK;

namespace GGJam_2021 {
    class BoxCollider : Collider {
        protected Vector2 size;
        protected Vector2 halfSize;

        public BoxCollider(Vector2 size) : base() {
            this.size = size;
            halfSize = size * 0.5f;
        }

        public override void Scale(float scaleFactory) {
            size *= scaleFactory;
            halfSize *= scaleFactory;
        }

        protected override bool Collides(BoxCollider box) {
            float deltaX = box.Position.X - Position.X;
            float deltaY = box.Position.Y - Position.Y;

            return (Math.Abs(deltaX) <= halfSize.X + box.halfSize.Y) && (Math.Abs(deltaY) <= halfSize.X + box.halfSize.Y);
        }

        protected override bool Collides(CircleCollider circle) {
            float deltaX = circle.Position.X - Math.Max(Position.X - halfSize.X, Math.Min(circle.Position.X, Position.X + halfSize.X));
            float deltaY = circle.Position.Y - Math.Max(Position.Y - halfSize.Y, Math.Min(circle.Position.Y, Position.Y + halfSize.Y));
            return (deltaX * deltaX + deltaY * deltaY) < (circle.Radius * circle.Radius);
        }
        //public void Update()
        //{
        //    sprite.position = Position;
        //}
        //public void Draw(float c, float d)
        //{
        //    sprite.DrawColor(c, d, 0);
        //}
    }
}
