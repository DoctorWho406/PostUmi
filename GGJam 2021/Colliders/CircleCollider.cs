using OpenTK;

namespace GGJam_2021 {
    class CircleCollider : Collider {
        public float Radius;
        public CircleCollider(Vector2 position, float radius) : base(position) {
            Radius = radius;
        }

        public override bool Collides(CircleCollider circle) {
            Vector2 distance = Position - circle.Position;
            return distance.Length < Radius + circle.Radius;
        }

        public override bool Collides(BoxCollider box) {
            //Da fare??
            throw new System.NotImplementedException();
        }
    }
}
