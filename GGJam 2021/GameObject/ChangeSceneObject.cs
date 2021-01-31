using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJam_2021
{
    class ChangeSceneObject : InteractableObject
    {
        protected Scene nextScene;

        public ChangeSceneObject(string textureName, LayerMask layerMask, Scene scene, Scene nextScene, ColliderType colliderType, int w = 0, int h = 0) : base(textureName, layerMask, scene, colliderType, w, h)
        {
            this.nextScene = nextScene;
        }
    }
}
