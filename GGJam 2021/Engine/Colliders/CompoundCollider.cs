using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter_2020
{
    class CompoundCollider : Collider
    {
        public Collider BoundingCollider;

        protected List<Collider> colliders;

        public CompoundCollider(RigidBody owner, Collider boundingCollider) : base(owner)
        {
            BoundingCollider = boundingCollider;
            colliders = new List<Collider>();
        }

        public virtual void AddCollider(Collider collider)
        {
            colliders.Add(collider);
        }

        public virtual bool InnerCollidersCollide(Collider collider)
        {
            //search for collision with inner colliders
            for (int i = 0; i < colliders.Count; i++)
            {
                if (collider.Collides(colliders[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public override bool Collides(Collider collider)
        {
            return collider.Collides(this);
        }

        public override bool Collides(BoxCollider box)
        {
            return (box.Collides(BoundingCollider) && InnerCollidersCollide(box));
        }

        public override bool Collides(CircleCollider circle)
        {
            return (circle.Collides(BoundingCollider) && InnerCollidersCollide(circle));
        }

        public override bool Collides(CompoundCollider other)
        {
            if (BoundingCollider.Collides(other.BoundingCollider))
            {
                for (int i = 0; i < colliders.Count; i++)
                {
                    for (int j = 0; j < other.colliders.Count; j++)
                    {
                        if (colliders[i].Collides(other.colliders[j]))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public override bool Contains(Vector2 point)
        {
            if (BoundingCollider.Contains(point))
            {
                for (int i = 0; i < colliders.Count; i++)
                {
                    if (colliders[i].Contains(point))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
