using OpenTK;

namespace GGJam_2021 {
    class Background : GameObject {
        public Background(string textureName, Vector2 offset, Vector2 colliderSize) : base(textureName, LayerMask.Background) {
            IsActive = true;

            Rigidbody = new Rigidbody(this);
            Rigidbody.Collider = new BoxCollider(Rigidbody, colliderSize * 0.5f);
            Rigidbody.Collider.Offset = offset;
            Rigidbody.Type = RigidBodyType.Background;
            Rigidbody.AddCollisionType(RigidBodyType.Player);
        }

        public override void OnCollide(GameObject other) {
            float radius = ((CircleCollider)other.Rigidbody.Collider).Radius;
            Vector2 position = other.Rigidbody.Position;
            if (!Rigidbody.Collider.Contains(position - radius * Vector2.UnitX)) {
                other.Position = new Vector2(radius, other.Position.Y);
            } else if (!Rigidbody.Collider.Contains(position + radius * Vector2.UnitX)) {
                other.Position = new Vector2(Game.Window.Width - radius, other.Position.Y);
            }
            if (!Rigidbody.Collider.Contains(position - radius * Vector2.UnitY)) {
                other.Position = new Vector2(other.Position.X, radius);
            } else if (!Rigidbody.Collider.Contains(position + radius * Vector2.UnitY)) {
                other.Position = new Vector2(other.Position.X, Game.Window.Height - radius);
            }
        }
    }
}
