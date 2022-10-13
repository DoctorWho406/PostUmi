using System.Collections.Generic;
using Aiv.Audio;
using Aiv.Fast2D;

namespace GGJam_2021 {
    static class GfxManager {
        private static Dictionary<string, Texture> textures;
        private static Dictionary<string, AudioClip> clips;

        static GfxManager() {
            textures = new Dictionary<string, Texture>();
            clips = new Dictionary<string, AudioClip>();
        }

        public static Texture AddTexture(string name, string texturePath) {
            Texture t = new Texture(texturePath);
            if (t != null) {
                textures[name] = t;
            }
            return t;
        }

        public static AudioClip AddClip(string name, string clipPath) {
            AudioClip c = new AudioClip(clipPath);
            if (c != null) {
                clips[name] = c;
            }
            return c;
        }

        public static Texture GetTexture(string name) {
            Texture t = null;
            if (textures.ContainsKey(name)) {
                t = textures[name];
            }
            return t;
        }

        public static AudioClip GetClip(string name) {
            AudioClip c = null;
            if (clips.ContainsKey(name)) {
                c = clips[name];
            }
            return c;
        }

        public static void ClearAll() {
            textures.Clear();
            clips.Clear();
        }
    }
}
