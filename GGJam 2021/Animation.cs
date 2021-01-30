using OpenTK;

namespace GGJam_2021 {
    class Animation {
        public bool IsPlaying {
            get; protected set;
        }

        protected int numFrames;
        protected float frameDuration;
        protected int currentFrame;
        protected float elapsedTime;

        protected int frameWidth;
        protected int frameHeight;

        public bool Loop;

        public Animation(int frameW, int frameH, float framePerSeconds, int numFrames, bool loop = true) {
            frameWidth = frameW;
            frameHeight = frameH;
            if (framePerSeconds > 0) {
                frameDuration = 1 / framePerSeconds;
            } else {
                frameDuration = 0;
            }
            this.numFrames = numFrames;
            Loop = loop;
        }

        public virtual void Update(ref Vector2 offset) {
            if (IsPlaying) {
                elapsedTime += Game.DeltaTime;
                if (elapsedTime >= frameDuration) {
                    currentFrame++;
                    elapsedTime = 0;
                    if (currentFrame >= numFrames) {
                        //animation ended
                        if (Loop) {
                            currentFrame = 0;
                        } else {
                            OnAnimationEnd();
                            return;
                        }
                    }
                    offset.X = frameWidth * currentFrame;
                }
            }
        }

        protected virtual void OnAnimationEnd() {
            IsPlaying = false;
        }

        public virtual void Play() {
            IsPlaying = true;
        }

        public virtual void Stop() {
            IsPlaying = false;
            currentFrame = 0;
            elapsedTime = 0;
        }

        public virtual void Pause() {
            IsPlaying = false;
        }
    }
}
