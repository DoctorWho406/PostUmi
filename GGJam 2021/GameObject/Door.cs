namespace GGJam_2021 {
    class Door : InteractableObject {
        private Scene next;

        public Door(string textureName, Scene actualScene, Scene nextScene) : base(textureName, LayerMask.Count, actualScene, ColliderType.BoxCollider) {
            next = nextScene;
        }

        public override void Update() {
            base.Update();
            if (IsClicked()) {
                SceneManager.LoadScene(next);
            }
        }
    }
}
