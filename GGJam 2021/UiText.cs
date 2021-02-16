namespace GGJam_2021 {
    class UIText : GameObject {
        public UIText(string textureName, Scene scene, int w = 0, int h = 0) : base(textureName, LayerMask.UI, scene, w, h) {
        }

        public override void Update() {
        }

        public override void Draw() {
            sprite.DrawTexture(texture);
        }
    }
}
