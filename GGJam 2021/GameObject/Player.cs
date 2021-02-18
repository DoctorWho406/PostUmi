using Aiv.Audio;
using OpenTK;

namespace GGJam_2021 {

    enum Status {
        FrontWalk,
        RightWalk,
        TopWalk,
        LeftWalk,
    }

    class Player : GameObject {
        public bool CanMove;

        private Vector2 speed;
        private Vector2 target;

        private Status status;
        private bool correctSide;

        public static AudioSource PlayerSoundEmitter;

        public static AudioClip Interaction;

        public Player() : base("Player", LayerMask.Middleground, 369, 654, 5) {
            IsActive = true;
            CanMove = true;

            Rigidbody = new Rigidbody(this);
            ColliderFactory.CreateCircleFor(this);
            Rigidbody.Type = RigidBodyType.Player;

            status = Status.FrontWalk;
            correctSide = true;
            target = -Vector2.One;
            //AudioStuff
            PlayerSoundEmitter = new AudioSource();
            Interaction = AudioManager.GetAudioClip("Interaction");
            PlayerSoundEmitter.Volume = 1f;
        }

        public void Input() {
            if (IsActive && IsVisible) {
                if (Game.Window.MouseRight) {
                    if (!InputManager.IsMovingButtonClicked) {
                        InputManager.IsMovingButtonClicked = true;
                        target = Game.Window.MousePosition;
                    }
                } else {
                    InputManager.IsMovingButtonClicked = false;
                }
            } else {
                Stop();
            }
        }

        public void Stop() {
            speed = Vector2.Zero;
            animation.Stop(ref textureOffset);
            target = -Vector2.One;
        }

        public override void Update() {
            base.Update();
            if (IsActive) {
                StatsManager.Update();
            }
            sprite.position += speed * Game.DeltaTime;
            if (target != -Vector2.One) {
                Vector2 distance = target - sprite.position;
                if (distance.X < distance.Y) {
                    if (distance.X < -distance.Y) {
                        status = Status.RightWalk;
                    } else {
                        status = Status.FrontWalk;
                    }
                } else {
                    if (distance.X < -distance.Y) {
                        status = Status.TopWalk;
                    } else {
                        status = Status.LeftWalk;
                    }
                }
                if (status == Status.LeftWalk) {
                    if (correctSide) {
                        correctSide = false;
                        sprite.FlipX = false;
                    }
                    textureOffset.Y = 654;
                } else if (status == Status.RightWalk && !correctSide) {
                    correctSide = true;
                    sprite.FlipX = true;
                } else {
                    textureOffset.Y = (int)status * 654;
                }
                animation.Update(ref textureOffset);
                if (!animation.IsPlaying) {
                    animation.Play();
                }
                if (distance.Length <= Constants.OffsetFromTarge) {
                    sprite.position = target;
                    Stop();
                } else {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                    //FootStepTime();
                }
            }
        }

        public override void Draw() {
            base.Draw();
            if (IsActive) {
                StatsManager.Draw();
            }
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            //((CircleCollider)Collider).Draw();
        }
    }
}
