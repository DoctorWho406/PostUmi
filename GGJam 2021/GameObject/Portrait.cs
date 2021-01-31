using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021
{
    class Portrait : ChangeSceneObject
    {
        public Portrait(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType, int w = 0, int h = 0) : base(textureName, layerMask, scene, nextScene, colliderType, w, h)
        {
        }

        public override void Update()
        {
            base.Update();
            if (IsClicked())
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
