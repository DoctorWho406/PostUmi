using OpenTK;

namespace GGJam_2021 {
    enum RigidBodyType {
    }

    class Rigidbody {
        protected uint collisionMask;

        public Vector2 Velocity;
        public GameObject GameObject;
        public bool IsGravityAffected;
        public bool IsCollisionsAffected = true;

        public RigidBodyType Type;
        public Collider Collider;


        public bool IsActive {
            get => GameObject.IsActive; set => GameObject.IsActive = value;
        }
        public Vector2 Position => GameObject.Position;

        public Rigidbody(GameObject owner) {
            GameObject = owner;
            PhysicsManager.AddItem(this);
        }

        //Collider

        public void Update() {
            //gravity
            //if (IsGravityAffected)
            //{
            //    Velocity.Y+= forza di gravità  *Game.DeltaTime;
            //}

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
