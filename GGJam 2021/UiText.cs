namespace GGJam_2021 {
    class UIText : GameObject {
        public UIText(string textureName, int w = 0, int h = 0, float fps = 0) : base(textureName, LayerMask.UI, w, h, fps) {
        }
    }
}
