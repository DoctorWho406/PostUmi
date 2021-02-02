using Aiv.Fast2D;
using OpenTK;

namespace GGJam_2021 {
    class Slider {
        private Sprite slider;
        private Sprite bg;
        private Texture textureBg;
        private Stat stat;
        private Vector4 color;

        public Slider(Vector2 position, Stat stat) {
            this.stat = stat;
            switch (stat) {
                case Stat.Hunger:
                    textureBg = TextureManager.GetTexture("Hunger");
                    bg = new Sprite(textureBg.Width, textureBg.Height);
                    bg.scale = new Vector2(Constants.HungerMax / bg.Width, 0.5f);
                    slider = new Sprite(Constants.HungerMax, textureBg.Height);
                    color = new Vector4(120, 131, 102, 255);
                    break;
                case Stat.Paranoia:
                    textureBg = TextureManager.GetTexture("Paranoia");
                    bg = new Sprite(textureBg.Width, textureBg.Height);
                    bg.scale = new Vector2(Constants.ParanoiaMax / bg.Width, 0.5f);
                    slider = new Sprite(Constants.ParanoiaMax, textureBg.Height);
                    color = new Vector4(125, 102, 131, 255);
                    break;
            }
            slider.position = position;
            bg.position = position;
        }

        public void Update() {
            slider.scale = new Vector2(stat == Stat.Paranoia ? StatsManager.Paranoia / Constants.ParanoiaMax : StatsManager.Hunger / Constants.HungerMax, 1);
        }

        public void Draw() {
            bg.DrawTexture(textureBg);
            slider.DrawColor(color);
        }
    }
}
