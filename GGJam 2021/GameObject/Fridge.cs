﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Threading.Tasks;

namespace GGJam_2021
{
    class Fridge : InteractableObject
    {
        protected Animation animation;

        private Vector2 textureOffset;
        public Fridge( Scene scene, ColliderType colliderType, int w = 0, int h = 0) : base("Frigorifero", LayerMask.Background, scene, colliderType, w, h)
        {
            animation = new Animation((int)sprite.Width, (int)sprite.Height, Constants.FPSDoorAnimation, 5, false);
            textureOffset = Vector2.Zero;
        }

        public override void Update()
        {
            animation.Update(ref textureOffset);
            base.Update();
            if (IsClicked(/*//il player non dovrebbe muoversi//*/))
            {
                StatsManager.AddStats(Constants.HungerFromFridge, Stat.Hunger);
            }
        }

        public override void Draw()
        {
            if (!glitch)
            {
                sprite.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
            }
            else
            {
                if (glithched)
                {
                    spriteGlitch1.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
                else
                {
                    spriteGlitch2.DrawTexture(texture, (int)textureOffset.X, (int)textureOffset.Y, (int)sprite.Width, (int)sprite.Height);
                }
            }
        }
    }
}