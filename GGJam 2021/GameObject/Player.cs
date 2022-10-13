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
        public override bool IsActive {
            set {
                base.IsActive = value;
                if (!value) {
                    CanMove = false;
                }
            }
        }
        public bool CanMove {
            get => canMove;
            set {
                canMove = value;
                if (!value) {
                    Stop();
                }
            }
        }

        private bool canMove;
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
            //AudioStuff
            PlayerSoundEmitter = new AudioSource();
            Interaction = AudioManager.GetAudioClip("Interaction");
            PlayerSoundEmitter.Volume = 1f;
            Scale(0.35f);
        }

        public void Input() {
            if (CanMove) {
                if (Game.Window.MouseRight) {
                    if (!InputManager.IsMovingButtonClicked) {
                        InputManager.IsMovingButtonClicked = true;
                        Rigidbody.MoveTo(Game.Window.MousePosition);
                    }
                } else {
                    InputManager.IsMovingButtonClicked = false;
                }
            }
        }

        public void Stop() {
            Rigidbody.Stop();
            animation.Stop(ref textureOffset);
        }

        public override void Update() {
            base.Update();
            if (IsActive) {
                StatsManager.Update();
            }
            //if (target != -Vector2.One) {
            //    Vector2 distance = target - sprite.position;
            //    if (distance.X < distance.Y) {
            //        if (distance.X < -distance.Y) {
            //            status = Status.RightWalk;
            //        } else {
            //            status = Status.FrontWalk;
            //        }
            //    } else {
            //        if (distance.X < -distance.Y) {
            //            status = Status.TopWalk;
            //        } else {
            //            status = Status.LeftWalk;
            //        }
            //    }
            //    if (status == Status.LeftWalk) {
            //        if (correctSide) {
            //            correctSide = false;
            //            sprite.FlipX = false;
            //        }
            //        textureOffset.Y = 654;
            //    } else if (status == Status.RightWalk && !correctSide) {
            //        correctSide = true;
            //        sprite.FlipX = true;
            //    } else {
            //        textureOffset.Y = (int)status * 654;
            //    }
            //    animation.Update(ref textureOffset);
            //    if (!animation.IsPlaying) {
            //        animation.Play();
            //    }
            //    if (distance.Length <= Constants.OffsetFromTarge) {
            //        sprite.position = target;
            //        Stop();
            //    } else {
            //        speed = distance.Normalized() * Constants.PlayerSpeed;
            //        //FootStepTime();
            //    }
            //}
        }

        public override void Draw() {
            base.Draw();
            if (IsActive) {
                StatsManager.Draw();
            }
        }
    }
}
