using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021
{
    class Slider
    {
        private Sprite slider;
        private Sprite bg;
        private Texture textureBg;
        private Stat stat;
        int r, g, b;

        public Slider(Vector2 position, Stat stat)
        {
            this.stat = stat;
            switch (stat)
            {
                case Stat.Hunger:
                    textureBg = TextureManager.GetTexture("Hunger");
                    bg = new Sprite(textureBg.Width, textureBg.Height);
                    bg.scale = new Vector2(Constants.HungerMax / bg.Width, Constants.SliderHeight / bg.Height);
                    slider = new Sprite(Constants.HungerMax, textureBg.Height);
                    slider.scale = new Vector2(1, Constants.SliderHeight / slider.Height);
                    slider.position = position;
                    r = 120;
                    g = 131;
                    b = 102;
                    break;
                case Stat.Paranoia:
                    textureBg = TextureManager.GetTexture("Paranoia");
                    bg = new Sprite(textureBg.Width, textureBg.Height);
                    bg.scale = new Vector2(Constants.ParanoiaMax / bg.Width, Constants.SliderHeight / bg.Height);
                    slider = new Sprite(Constants.ParanoiaMax, textureBg.Height);
                    slider.scale = new Vector2(1, Constants.SliderHeight / slider.Height);
                    slider.pivot = Vector2.UnitX * slider.Width;
                    slider.position = position + Vector2.UnitX * slider.Width;
                    r = 125;
                    g = 102;
                    b = 131;
                    break;
            }
            bg.position = position;
        }

        public void Update()
        {
            slider.scale = new Vector2(stat == Stat.Paranoia ? 1 - (StatsManager.Paranoia / Constants.ParanoiaMax) : 1 - (StatsManager.Hunger / Constants.HungerMax), slider.scale.Y);
        }

        public void Draw()
        {
            bg.DrawTexture(textureBg);
            slider.DrawColor(r, g, b);
        }
    }
}
