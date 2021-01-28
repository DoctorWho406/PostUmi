using OpenTK;

namespace GGJam_2021 {
    class Player : AnimatedObject {
        private Vector2 target;

        public Player(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60) : base(position, size, rowsSpriteSheet, columnsSpriteSheet, fps) {
            texture = TextureManager.GetTexture("Player");
            target = Vector2.Zero;
            DrawManager.AddItem(this);
            UpdateManager.AddItem(this);
        }

        public void Input() {
            if (Game.Window.MouseLeft) {
                target = Game.Window.MousePosition;
            }
        }

        public override void Update() {
            if (target != Vector2.Zero) {
                Vector2 distance = target - position;
                if (distance.Length <= Constants.offsetFromTarge) {
                    position = target;
                    target = Vector2.Zero;
                    speed = Vector2.Zero;
                } else {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                }
            }
            base.Update();
        }

    }
}
