using OpenTK;

namespace GGJam_2021 {
    class Door : ChangeSceneObject {
        public Vector2 positionPlayer;

        public Door(string texturName, Vector2 positionPlayer, bool Flip = false, int w = 0, int h = 0, int fps = 0, LayerMask layerMask = LayerMask.Background) : base(texturName, layerMask, w, h, fps) {
            sprite.FlipX = Flip;
            spriteGlitch1.FlipX = Flip;
            spriteGlitch2.FlipX = Flip;
            this.positionPlayer = positionPlayer;
        }
    }
}
