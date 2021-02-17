﻿using OpenTK;


namespace GGJam_2021 {
    class Portrait : ChangeSceneObject {
        public bool isOpened {
            get; set;
        }

        private float paranoia;

        public Portrait(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType, int fotogrammi = 0, int fps = 0, int w = 0, float paranoia = 0) : base(textureName, layerMask, scene, nextScene, colliderType, w, 0) {
            isOpened = false;
            if (fotogrammi == 0) {
                animation = null;
            } else {
                this.paranoia = paranoia;
            }
        }

        public override void Update() {
            base.Update();
            if (animation != null) {
                if (IsClicked()) {
                    StatsManager.AddStats(paranoia, Stats.Paranoia);
                    SceneManager.LoadScene(nextScene);
                }
                animation.Update(ref textureOffset);
                if (SceneManager.ActiveScene == scene) {
                    animation.Play();
                }
            } else if (IsNearAndClicked()) {
                if (InteractableObjectManager.CanOpenIt(this)) {
                    SceneManager.LoadScene(nextScene);
                    if (!isOpened) {
                        MusicManager.ObjectTaken++;
                    }
                    isOpened = true;
                }

            }
        }
        public override void Draw() {
            if (animation != null) {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            } else {
                base.Draw();
            }
        }
    }
}

