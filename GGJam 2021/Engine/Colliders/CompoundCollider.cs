using System.Collections.Generic;
using OpenTK;

namespace GGJam_2021 {
    class CompoundCollider : Collider {
        public Collider BoundingCollider;
        protected List<Collider> innerColliders;

        public CompoundCollider(Rigidbody owner, Collider boundingCollider) : base(owner) {
            BoundingCollider = boundingCollider;
            innerColliders = new List<Collider>();
        }

        public override void Scale(float scaleFactor) {
            base.Scale(scaleFactor);
            BoundingCollider.Scale(scaleFactor);
            foreach (Collider collider in innerColliders) {
                collider.Scale(scaleFactor);
            }
        }

        public virtual void AddCollider(Collider collider) {
            innerColliders.Add(collider);
        }

        public virtual bool InnerCollidersCollide(Collider other) {
            for (int i = 0; i < innerColliders.Count; i++) {
                if (innerColliders[i].Collides(other)) {
                    return true;
                }
            }
            return false;
        }

        public override bool Collides(Collider collider) {
            return collider.Collides(this);
        }

        public override bool Collides(CompoundCollider compoundCollider) {
            if (BoundingCollider.Collides(compoundCollider.BoundingCollider)) {
                for (int i = 0; i < compoundCollider.innerColliders.Count; i++) {
                    //if (InnerCollidersCollide(compoundCollider.innerColliders[i])) {
                    //    return true;
                    //}
                    for (int j = 0; j < innerColliders.Count; j++) {
                        if (innerColliders[j].Collides(compoundCollider.innerColliders[i])) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public override bool Collides(CircleCollider circle) {
            return circle.Collides(BoundingCollider) && InnerCollidersCollide(circle);
        }

        public override bool Collides(BoxCollider box) {
            return box.Collides(BoundingCollider) && InnerCollidersCollide(box);
        }

        public override bool Contains(Vector2 point) {
            if (BoundingCollider.Contains(point)) {
                for (int i = 0; i < innerColliders.Count; i++) {
                    if (innerColliders[i].Contains(point)) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
