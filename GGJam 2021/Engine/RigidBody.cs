using OpenTK;

namespace GGJam_2021 {
    enum RigidBodyType {
        Player = 1,
        Cursor = 2,
    }

    class Rigidbody {
        public Vector2 Velocity;
        public GameObject GameObject;
        public bool IsGravityAffected;
        public bool IsCollisionsAffected = true;

        public RigidBodyType Type;
        public Collider Collider;

        protected uint collisionMask;
        protected Vector2 target;

        public bool IsActive {
            get => GameObject.IsActive; set => GameObject.IsActive = value;
        }
        public Vector2 Position => GameObject.Position;

        public Rigidbody(GameObject owner) {
            GameObject = owner;
            PhysicsManager.AddItem(this);
        }

        public void MoveTo(Vector2 target) {
            this.target = target;
        }

        public void Update() {
            //gravity
            //if (IsGravityAffected)
            //{
            //    Velocity.Y+= forza di gravità  * Game.DeltaTime;
            //}
            if (target != GameObject.Position) {
                Vector2 distance = target - GameObject.Position;
                if (distance.Length <= Constants.OffsetFromTarge) {
                    Velocity = Vector2.Zero;
                    GameObject.Position = target;
                } else {
                    //Velocity = distance.Normalized();
                }
            }
            GameObject.Position += Velocity * Game.DeltaTime;
        }

        public void AddCollisionType(RigidBodyType type) {
            //collisionMask = collisionMask | (uint)type;
            collisionMask |= (uint)type;
        }

        public void AddCollisionType(uint value) {
            collisionMask |= value;
        }

        public bool CollisionTypeMatches(RigidBodyType type) {
            return ((uint)type & collisionMask) != 0;
        }

        public bool Collides(Rigidbody other) {
            return Collider.Collides(other.Collider);
        }
    }
}
