using OpenTK;
using Aiv.Fast2D;


namespace GGJam_2021
{
    class Player
    {
        Texture texturePl;
        Sprite textureSp;
        private Vector2 target;
        private Vector2 speed;

        public Player(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60)
        {
            texturePl = TextureManager.GetTexture("Player");
            textureSp = new Sprite(texturePl.Width, texturePl.Height);
            textureSp.position = position;
                //positon=new Vector2(Game.Window.Width*0.5f,Game.Window.Height*0.5f);
            target = Vector2.Zero;
            speed = new Vector2(fps);
        }
        public void Input()
        {
            if (Game.Window.MouseLeft)
            {
                target = Game.Window.MousePosition;
            }
        }

        public void Update()
        {
            if (target != Vector2.Zero)
            {
                Vector2 distance = target - textureSp.position;
                if (distance.Length <= Constants.offsetFromTarge)
                {
                    textureSp.position = target;
                    target = Vector2.Zero;
                    speed = Vector2.Zero;
                }
                else
                {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                }
            }
        }
        public void Draw()
        {
            textureSp.DrawTexture(texturePl);
        }
    }
}
