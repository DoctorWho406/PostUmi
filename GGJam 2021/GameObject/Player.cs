using Aiv.Audio;
using OpenTK;

namespace GGJam_2021 {

    enum Status {
        Idle,
        Walk
    }

    class Player : ColliderObject {
        private Vector2 speed;

        private Vector2 target;

        private Animation animation;
        private Vector2 textureOffset;
        private Status status;

        public static AudioSource PlayerSoundEmitter;

        private static AudioClip footStep;
        public static AudioClip Interaction;
        private float counterTime;


        public Player() : base("Player", LayerMask.Middleground, Scene.Always, ColliderType.CircleCollider, 0, 0) {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSPlayerAnimation, 5, true);
            sprite.position = new Vector2(886, 570);
            Collider.Position = sprite.position;
            //((CircleCollider)Collider).sprite.position = Collider.Position;
            Collider.Scale(0.5f);
            textureOffset = Vector2.Zero;
            sprite.scale = new Vector2(0.5f);
            status = Status.Idle;
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.75f);
            target = -Vector2.One;
            //AudioStuff
            PlayerSoundEmitter = new AudioSource();
            footStep = AudioManager.GetAudioClip("FootStep");
            Interaction = AudioManager.GetAudioClip("Interaction");
            PlayerSoundEmitter.Volume = 1f;
            counterTime = 0;
        }

        public void Input() {
            if (Game.Window.MouseLeft) {
                if (!InputManager.IsMovingButtonClicked) {
                    InputManager.IsMovingButtonClicked = true;
                    target = Game.Window.MousePosition;
                }
            } else {
                InputManager.IsMovingButtonClicked = false;
            }
        }

        public void FootStepTime() {
            if (counterTime <= 0) {
                PlayerSoundEmitter.Play(footStep);
                counterTime = 0.5f;
            }
            counterTime -= Game.DeltaTime;
        }

        public void Stop() {
            speed = Vector2.Zero;
            //animation.Stop(ref textureOffset);
            target = -Vector2.One;
        }

        public override void Update() {
            sprite.position += speed * Game.DeltaTime;
            base.Update();
            animation.Play();
            if (target != -Vector2.One) {
                if (status != Status.Walk) {
                    status = Status.Walk;
                }
                Vector2 distance = target - sprite.position;
                if (distance.Length <= Constants.OffsetFromTarge) {
                    sprite.position = target;
                    Stop();
                } else {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                    FootStepTime();
                }

            }
        }

        public override void Draw() {
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            //((CircleCollider)Collider).Draw();
        }
    }
}
