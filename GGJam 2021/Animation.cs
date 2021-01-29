using OpenTK;

namespace GGJam_2021 {
    class Animation {
        protected int numFrames;
        protected float frameDuration;
        protected bool isPlaying;
        protected int currentFrame;
        protected float elapsedTime;

        protected int frameWidth;
        protected int frameHeight;

        public bool Loop;

        public Animation(int frameW, int frameH, float framePerSeconds, int numFrames, bool loop = true) {
            frameWidth = frameW;
            frameHeight = frameH;
            frameDuration = 1 / framePerSeconds;
            this.numFrames = numFrames;
            Loop = loop;
        }

        public virtual void Update(ref Vector2 offset) {
            if (isPlaying) {
                elapsedTime += Game.Window.DeltaTime;
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
            isPlaying = false;
        }

        public virtual void Play() {
            isPlaying = true;
        }

        public virtual void Stop() {
            isPlaying = false;
            currentFrame = 0;
            elapsedTime = 0;
        }

        public virtual void Pause() {
            isPlaying = false;
        }
    }
}
