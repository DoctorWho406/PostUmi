using OpenTK;

namespace GGJam_2021 {
    class CircleCollider : Collider {
        public float Radius;
        public CircleCollider(float radius) : base() {
            Radius = radius;
        }

        public override void Scale(float scaleFactory) {
            Radius *= scaleFactory;
        }

        protected override bool Collides(CircleCollider circle, out Vector2 offset)
        {
            offset = Vector2.Zero;
            Vector2 distance = Position - circle.Position;
            if (distance.Length < Radius + circle.Radius)
            {
                offset = distance.Normalized() * (Radius + circle.Radius - distance.Length);
                return true;
            }
            return false;
        }

        protected override bool Collides(BoxCollider box) {
            //Da fare??
            throw new System.NotImplementedException();
        }
    }
}
