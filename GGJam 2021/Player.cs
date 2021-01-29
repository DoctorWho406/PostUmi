using OpenTK;


namespace GGJam_2021 {

    enum Stat {
        Hunger,
        Paranoia,
        Count
    }

    class Player : ColliderObject {
        public bool IsAlive => Hunger > 0 && Paranoia > 0;
        public float Hunger {
            get; private set;
        }
        public float Paranoia {
            get; private set;
        }

        private Vector2 target;
        private Slider paranoiaSlider, hungherSlider;


        public Player(Scene scene) : base("Player", scene, ColliderType.CircleCollider, true) {
            sprite.scale = new Vector2(0.3f);
            sprite.pivot = new Vector2(0, sprite.Height * 0.5f);
            Collider = new CircleCollider(sprite.pivot.Y);

            target = -Vector2.One;

            Hunger = 1f;
            Paranoia = 1f;
            paranoiaSlider = new Slider(new Vector2(25), Stat.Paranoia);
            hungherSlider = new Slider(new Vector2(25, Game.Window.Height - 75), Stat.Hunger);
        }

        public void Input() {
            if (Game.Window.MouseLeft) {
                target = Game.Window.MousePosition;
            }
        }

        public override void Update() {
            if (IsAlive) {
                Collider.Position = sprite.position;
                if (target != -Vector2.One) {
                    base.Update();
                    Vector2 distance = target - sprite.position;
                    if (distance.Length <= Constants.OffsetFromTarge) {
                        sprite.position = target;
                        target = -Vector2.One;
                        speed = Vector2.Zero;
                    } else {
                        speed = distance.Normalized() * Constants.PlayerSpeed;
                    }
                }
            }

            //Decrese hungry and paranoia
            //Hunger -= Constants.HungerDecrease * Game.DeltaTime;
            //Paranoia -= Constants.ParanoiaDecrease * Game.DeltaTime;

            //Update Slider
            paranoiaSlider.Update();
            hungherSlider.Update();
        }

        public override void Draw() {
            base.Draw();
            //Draw Slider
            paranoiaSlider.Draw();
            hungherSlider.Draw();
        }
    }
}
