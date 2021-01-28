using Aiv.Fast2D;
using OpenTK;


namespace GGJam_2021
{

    enum Stat
    {
        Hunger,
        Paranoia,
        Count
    }
    class Player
    {
        public bool isAlive => hunger > 0 && paranoia > 0;
        public float hunger
        {
            get; private set;
        }
        public float paranoia
        {
            get; private set;
        }
        private Texture texture;
        private Sprite sprite;
        
        private Vector2 target;
        private Vector2 speed;
        private Slider paranoiaSlider, hungherSlider;


        public Player(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60)
        {
            texture = TextureManager.GetTexture("Player");
            sprite = new Sprite(texture.Width, texture.Height)
            {
                position = position
            };
            sprite.scale = new Vector2(0.3f);
            sprite.pivot = new Vector2(0, sprite.Height * 0.5f);
            target = -Vector2.One;
            hunger = 1f;
            paranoia = 1f;
            paranoiaSlider = new Slider(new Vector2(25), Stat.Paranoia);
            hungherSlider = new Slider(new Vector2(25, Game.Window.Height - 75), Stat.Hunger);
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
            if (target != -Vector2.One)
            {
                sprite.position += speed * Game.DeltaTime;
                Vector2 distance = target - sprite.position;
                if (distance.Length <= Constants.offsetFromTarge)
                {
                    sprite.position = target;
                    target = -Vector2.One;
                    speed = Vector2.Zero;
                }
                else
                {
                    speed = distance.Normalized() * Constants.PlayerSpeed;
                }
            }

            //Decrese hungry and paranoia
            hunger -= Constants.hungerDecrease * Game.DeltaTime;
            paranoia -= Constants.paranoiaDecrease * Game.DeltaTime;

            //Update Slider
            paranoiaSlider.Update();
            hungherSlider.Update();
        }

        public void Draw()
        {
            sprite.DrawTexture(texture);
            //Draw Slider
            paranoiaSlider.Draw();
            hungherSlider.Draw();
        }
    }
}
