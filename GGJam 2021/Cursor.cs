//using Aiv.Fast2D;
//using OpenTK;

//namespace GGJam_2021 {
//    class Cursor {
//        public CircleCollider Collider;

//        private Texture texture;
//        private Sprite sprite;

//        public Cursor() {
//            texture = TextureManager.GetTexture("Cursor");
//            sprite = new Sprite(texture.Width, texture.Height) {
//                position = Game.Window.MousePosition,
//                scale = new Vector2(0.2f)
//            };
//            Collider = new CircleCollider(sprite.Width);
//        }

//        public void Update() {
//            sprite.position = Game.Window.MousePosition;
//            Collider.Position = sprite.position;
//        }

//        public void Draw() {
//            sprite.DrawTexture(texture);
//        }
//    }
//}
using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    class Cursor : ColliderObject
    {
        public Cursor() : base("Cursor", LayerMask.UI, Scene.Always, ColliderType.CircleCollider)
        {
        }

        public override void Update()
        {
            sprite.position = Game.Window.MousePosition;
        }
    }
}
