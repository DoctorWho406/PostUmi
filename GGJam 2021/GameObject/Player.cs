using OpenTK;


namespace GGJam_2021
{

    enum Status
    {
        Idle,
        Walk
    }

    class Player : ColliderObject
    {
        private Vector2 speed;

        private Vector2 target;

        private Animation animation;
        private Vector2 textureOffset;
        private Status status;

        public Player() : base("Player", LayerMask.Middleground, Scene.Always, ColliderType.CircleCollider)
        {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSPlayerAnimation, 5, false);
            textureOffset = Vector2.Zero;
            status = Status.Idle;
            sprite.pivot = new Vector2(0, sprite.Height * 0.5f);

            target = -Vector2.One;
        }

        public void Input()
        {
            if (Game.Window.MouseLeft)
            {
                target = Game.Window.MousePosition;
            }
        }

        public void Stop()
        {
            speed = Vector2.Zero;
            animation.Stop(ref textureOffset);
            target = -Vector2.One;
        }

        public override void Update()
        {
            sprite.position += speed * Game.DeltaTime;
            if (target != -Vector2.One)
            {
                if (status != Status.Walk)
                {
                    status = Status.Walk;
                    animation.Play();
                }
                base.Update();
                Vector2 distance = target - sprite.position;
                if (distance.Length <= Constants.OffsetFromTarge)
                {
                    sprite.position = target;
                    Stop();
                }
                else
                {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                }
            }
        }

        public override void Draw()
        {
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
        }
    }
}
