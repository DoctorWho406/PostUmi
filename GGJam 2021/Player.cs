using OpenTK;
using Aiv.Fast2D;


namespace GGJam_2021
{

    enum Stat
    {
        FAME,
        PARANOIA,
        COUNT
    }
    class Player
    {
        Texture texturePl;
        Sprite textureSp;
        public bool isAlive => hunger > 0 && paranoia > 0;

        //Adesso pensavo di creare la classe Slider che serve per mostrare le barre di fame e paranoia 
        //Solamente che io non posso creare le classi da qua ok

        private Vector2 target;
        private Vector2 speed;
        private Slider paranoiaSlider, hungherSlider;

        public float hunger
        {
            get; private set;
        }

        public float paranoia
        {
            get; private set;
        }

        public Player(Vector2 position, Vector2 size, int rowsSpriteSheet = 1, int columnsSpriteSheet = 1, int fps = 60)
        {
            texturePl = TextureManager.GetTexture("Player");
            textureSp = new Sprite(texturePl.Width, texturePl.Height);
            textureSp.position = position;
            //positon=new Vector2(Game.Window.Width*0.5f,Game.Window.Height*0.5f);
            target = Vector2.Zero;
            textureSp.scale = new Vector2(0.3f);
            hunger = 1f;
            paranoia = 1f;
            paranoiaSlider = new Slider(Vector2.Zero, Stat.PARANOIA);
            hungherSlider = new Slider(new Vector2(0, Game.Window.Height - 75), Stat.FAME);
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
                textureSp.position += speed * Game.DeltaTime;
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

            //Decrese hungry and paranoia
            hunger -= Constants.hungerDecrease * Game.DeltaTime;
            paranoia -= Constants.paranoiaDecrease * Game.DeltaTime;
            System.Console.WriteLine(hunger);
            System.Console.WriteLine(paranoia);

            paranoiaSlider.Update();
            hungherSlider.Update();

        }
        public void Draw()
        {
            textureSp.DrawTexture(texturePl);
            paranoiaSlider.Draw();
            hungherSlider.Draw();
            //Provalo
        }
    }
}
