using OpenTK;

namespace GGJam_2021 {
    class Animation {
        public bool IsPlaying {
            get; private set;
        }
        public Vector2 Offset;
        private bool Loop;

        private AnimatedObject owner;
        private Vector2 startOffset;
        private int rows, actualRow, columns, actualColumn;
        private float frameDuration, currentTime = 0.0f;

        public Animation(AnimatedObject owner, int rows, int columns, float fps) {
            startOffset = Vector2.Zero;
            this.owner = owner;
            this.rows = rows;
            this.columns = columns;
            if (fps > 0.0f) {
                frameDuration = 1 / fps;
            } else if (fps < 0.0f) {
                frameDuration = -1 / fps;
            } else {
                frameDuration = 0.0f;
            }
        }

        public Animation(AnimatedObject owner, int rows, int columns, Vector2 offset, float fps) {
            this.owner = owner;
            this.rows = rows - 1;
            this.columns = columns - 1;
            Offset = offset;
            startOffset = offset;
            if (fps > 0.0f) {
                frameDuration = 1 / fps;
            } else if (fps < 0.0f) {
                frameDuration = -1 / fps;
            } else {
                frameDuration = 0.0f;
            }
        }

        public void Update() {
            if (IsPlaying) {
                currentTime += Game.DeltaTime;
                if (currentTime >= frameDuration) {
                    currentTime = 0;
                    if (actualColumn < columns) {
                        Offset.X = startOffset.X + (actualColumn * owner.Size.X);
                        actualColumn++;
                    } else {
                        actualColumn = 0;
                        if (actualRow < rows) {
                            Offset.Y = startOffset.Y + (actualRow * owner.Size.Y);
                            actualRow++;
                        } else {
                            if (Loop) {
                                Offset = startOffset;
                                actualRow = 0;
                            } else {
                                Stop();
                            }
                        }
                    }
                }
            }
        }

        public void Play(bool loop) {
            Play();
            Loop = loop;
        }

        public void Play() {
            IsPlaying = true;
        }

        public void Stop() {
            Offset = startOffset;
            actualRow = 1;
            actualColumn = 1;
            IsPlaying = false;
        }

        public void Pause() {
            IsPlaying = false;
        }
    }
}