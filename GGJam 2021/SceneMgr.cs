using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aiv.Fast2D;
using OpenTK;
using System.Threading.Tasks;

namespace GGJam_2021
{
    enum Scene
    {
        soggiorno,
        stanza,
        corridoio,
        Count
    }
    static class SceneMgr
    {
        private static Scene ActiveScene;
        private static Dictionary<Scene, List</*da definire*/>> rooms;
        static SceneMgr()
        {
            rooms = new Dictionary<Scene, List</*da definire*/>>();
            for (int i = 0; i < (int)Scene.Count; i++)
            {
                rooms[(Scene)i] = new List</*da definire*/>();
            }
        }
        public static void AddtoScene(Scene room, /*da definire*/)
        {
            rooms[room].Add(/*da definire*/);
        }
        public static void loadScene(Scene Scene)
        {
            ActiveScene = Scene;
        }
        public static void Draw()
        {
            foreach (/*da definire*/ in rooms[ActiveScene])
            {
                /*da definire*/.Draw();
            }
        }
    }

}
