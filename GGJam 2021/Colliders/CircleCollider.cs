﻿using OpenTK;

namespace GGJam_2021 {
    class CircleCollider : Collider {
        public float Radius;
        public CircleCollider(float radius) : base() {
            Radius = radius;
        }

        public override bool Collides(CircleCollider circle) {
            Vector2 distance = Position - circle.Position;
            return distance.Length < Radius + circle.Radius;
        }

        public override bool Collides(BoxCollider box) {
            //Da fare??
            throw new System.NotImplementedException();
        }
    }
}