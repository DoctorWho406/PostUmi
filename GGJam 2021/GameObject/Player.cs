﻿using Aiv.Audio;
using OpenTK;

namespace GGJam_2021 {

    enum Status {
        FrontWalk,
        RightWalk,
        TopWalk,
        LeftWalk,
    }

    class Player : ColliderObject {
        public bool IsActive {
            get; private set;
        }
        public bool IsVisible {
            get; private set;
        }

        private Vector2 speed;
        private Vector2 target;

        private Animation animation;
        private Vector2 textureOffset;
        private Status status;
        private bool correctSide;

        public static AudioSource PlayerSoundEmitter;

        public static AudioClip Interaction;

        public Player() : base("Player", LayerMask.Middleground, Scene.Always, ColliderType.CircleCollider,369, 654) {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSPlayerAnimation, 8, true);
            status = Status.FrontWalk;

            textureOffset = Vector2.Zero;
            correctSide = true;

            sprite.position = new Vector2(886, 570);
            Collider.Position = sprite.position;
            Collider.Scale(0.5f);
            sprite.scale = new Vector2(0.5f);
            sprite.pivot = new Vector2(sprite.Width * 0.5f, sprite.Height * 0.75f);
            target = -Vector2.One;
            //AudioStuff
            PlayerSoundEmitter = new AudioSource();
            Interaction = AudioManager.GetAudioClip("Interaction");
            PlayerSoundEmitter.Volume = 1f;
        }

        public void SetIsVisible(bool value) {
            if (value) {
                Stop();
            }
            IsVisible = value;
        }

        public void SetIsActive(bool value) {
            if (value) {
                Stop();
            }
            IsActive = value;
        }

        public void Input() {
            if (IsActive && IsVisible) {
                if (Game.Window.MouseLeft) {
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
            sprite.position += speed * Game.DeltaTime;
            base.Update();
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
            sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            //((CircleCollider)Collider).Draw();
        }
    }
}
