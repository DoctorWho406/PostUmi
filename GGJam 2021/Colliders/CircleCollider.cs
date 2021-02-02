using OpenTK;

namespace GGJam_2021 {
    class CircleCollider : Collider {
        public float Radius;

        //public Sprite sprite;
        public CircleCollider(float radius) : base() {
            Radius = radius;

            //float halfRadius = Radius * 0.5f;
            //sprite = new Sprite(radius, radius) { pivot = new Vector2(halfRadius) };
        }

        public override void Scale(float scaleFactory) {
            Radius *= scaleFactory;

            //sprite.scale = new Vector2(scaleFactory);
        }

        public override bool Collides(CircleCollider circle, out Vector2 offset) {
            offset = Vector2.Zero;
            Vector2 distance = circle.Position - Position;
            if (distance.Length < Radius + circle.Radius) {
                offset = distance.Normalized() * (Radius + circle.Radius - distance.Length + 1);
                return true;                
            }
            return false;
        }

        protected override bool Collides(BoxCollider box) {
            //Da fare??
            throw new System.NotImplementedException();
        }

        //public void Draw() {
        //    sprite.DrawWireframe(0, 255, 0);
        //}
    }
}
