﻿namespace GGJam_2021 {
    class Cursor : GameObject {
        public Cursor() : base("Cursor", LayerMask.UI) {
            IsActive = true;
            Position = Game.Window.MousePosition;

            Rigidbody = new Rigidbody(this);
            ColliderFactory.CreateCircleFor(this);
            Rigidbody.Type = RigidBodyType.Cursor;
        }

        public override void Update() {
            Position = Game.Window.MousePosition;
        }
    }
}
