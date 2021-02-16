using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter_2020
{
    class BoxCollider : Collider
    {
        protected float halfWidth;
        protected float halfHeight;

        public float Width { get { return halfWidth * 2; } }
        public float Height { get { return halfHeight * 2; } }

        public BoxCollider(RigidBody owner, int w, int h) : base(owner)
        {
            halfWidth = w * 0.5f;
            halfHeight = h * 0.5f;
        }

        public override bool Collides(Collider collider)
        {
            return collider.Collides(this);
        }

        public override bool Collides(CircleCollider circle)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(Vector2 point)
        {
            return
                point.X >= Position.X - halfWidth &&
                point.X <= Position.X + halfWidth &&
                point.Y >= Position.Y - halfHeight &&
                point.Y <= Position.Y + halfHeight;
        }

        public override bool Collides(BoxCollider other)
        {
            float deltaX = other.Position.X - Position.X;
            float deltaY = other.Position.Y - Position.Y;

            return
                (Math.Abs(deltaX) <= halfWidth + other.halfWidth) &&
                (Math.Abs(deltaY) <= halfHeight + other.halfHeight);
        }
    }
}
