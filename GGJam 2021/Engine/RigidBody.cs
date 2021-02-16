using System;
using OpenTK;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021
{
    enum RigidBodyType {}

    class RigidBody
    {
        protected uint collisionMask;

        public Vector2 Velocity;
        public GameObject GameObject;
        public bool IsGravityAffected;
        public bool IsCollisionsAffected = true;

        public RigidBodyType Type;
        public Collider Collider;


        public bool IsActive { get { return GameObject.IsActive; } set { GameObject.IsActive = value; } }
        public Vector2 Position { get { return GameObject.Position; } }

        public RigidBody(GameObject owner)
        {
            GameObject = owner;
            PhysicsMgr.AddItem(this);
        }

        //Collider

        public void Update()
        {
            //gravity
            //if (IsGravityAffected)
            //{
            //    Velocity.Y+= forza di gravità  *Game.DeltaTime;
            //}

            GameObject.Position += Velocity * Game.DeltaTime;
        }

        public void AddCollisionType(RigidBodyType type)
        {
            //collisionMask = collisionMask | (uint)type;
            collisionMask |= (uint)type;
        }

        public void AddCollisionType(uint value)
        {
            collisionMask |= value;
        }

        public bool CollisionTypeMatches(RigidBodyType type)
        {
            return ((uint)type & collisionMask) != 0;
        }

        public bool Collides(RigidBody other)
        {
            return Collider.Collides(other.Collider);
        }
    }
}
