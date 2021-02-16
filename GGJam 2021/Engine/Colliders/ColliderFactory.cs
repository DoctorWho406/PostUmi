using System;

namespace GGJam_2021 {
    static class ColliderFactory {
        public static CircleCollider CreateCircleFor(GameObject obj, bool innerCircle = true) {
            float radius;
            if (innerCircle) {
                if (obj.halfSize.X < obj.halfSize.Y) {
                    radius = obj.halfSize.X;
                } else {
                    radius = obj.halfSize.Y;
                }
            } else {
                radius = (float)Math.Sqrt(obj.halfSize.X * obj.halfSize.X + obj.halfSize.Y * obj.halfSize.Y);
            }
            return new CircleCollider(obj.Rigidbody, radius);
        }

        public static BoxCollider CreateBoxCollider(GameObject obj) {
            return new BoxCollider(obj.Rigidbody, obj.halfSize);
        }
    }
}
