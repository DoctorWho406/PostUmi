namespace GGJam_2021 {
    class Button : ChangeSceneObject {
        public Button(string textureName,Scene scene,Scene nextscene, ColliderType colliderType) : base(textureName, LayerMask.Middleground, scene, nextscene, colliderType) {
        }

        public override void SetGlitch(bool value) {
        }

        public override void Update() {
            base.Update();
            if (IsClicked()) {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
