using System;

namespace GGJam_2021 {
    static class ColliderFactory {
        public static CircleCollider CreateCircleFor(GameObject obj, bool innerCircle = true) {
            float radius;
            if (innerCircle) {
                if (obj.HalfSize.X < obj.HalfSize.Y) {
                    radius = obj.HalfSize.X;
                } else {
                    radius = obj.HalfSize.Y;
                }
            } else {
                radius = (float)Math.Sqrt(obj.HalfSize.X * obj.HalfSize.X + obj.HalfSize.Y * obj.HalfSize.Y);
            }
            return new CircleCollider(obj.Rigidbody, radius);
        }

        public static BoxCollider CreateBoxCollider(GameObject obj) {
            return new BoxCollider(obj.Rigidbody, obj.HalfSize);
        }
    }
}
