using System.Collections.Generic;
using Aiv.Fast2D;

namespace GGJam_2021 {
    static class TextureManager {
        private static Dictionary<string, Texture> textures;

        static TextureManager() {
            textures = new Dictionary<string, Texture>();
        }

        public static void AddTexture(string key, string texturePath) {
            Texture t = new Texture(texturePath);
            textures[key] = t;
        }

        public static Texture GetTexture(string key) {
            Texture t = null;
            if (textures.ContainsKey(key)) {
                t = textures[key];
            }
            return t;
        }

        public static void Clear() {
            textures.Clear();
        }
    }
}
