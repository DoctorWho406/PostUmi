using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    class Cursor
    {
        Texture cursor;
        Sprite cursorSprite;
        public Vector2 positionMouse { get { return cursorSprite.position; } set { cursorSprite.position = value; } }

        public Cursor()
        {
            cursor = TextureManager.GetTexture("Cursor");
            cursorSprite = new Sprite(cursor.Width, cursor.Height);
            cursorSprite.position = Game.Window.MousePosition;
            cursorSprite.scale = new Vector2(0.2f);
        }
        public void Update()
        {
            positionMouse = Game.Window.MousePosition;
        }
        public void Draw()
        {
            cursorSprite.DrawTexture(cursor);
        }
    }
}
