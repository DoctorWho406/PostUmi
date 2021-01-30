﻿using System.Collections.Generic;

namespace GGJam_2021 {
    enum Scene {
        Always,
        Room,
        AnteroomExit,
        CentralCorridor,
        LoungeArea,
        Kitchen,
        Bathroom,
        Corridor,
        Laboratory,
        BedroomParents,
        //Add Dialogue Scene
        Count
    }

    static class SceneManager {
        private static Scene activeScene;
        private static Dictionary<Scene, List<GameObject>> scenes;
        private static bool isSceneChanging;

        static SceneManager() {
            isSceneChanging = false;
            activeScene = Scene.Room;
            scenes = new Dictionary<Scene, List<GameObject>>();
            for (int s = 0; s < (int)Scene.Count; s++) {
                scenes[(Scene)s] = new List<GameObject>();
            }
        }

        public static void AddGOToScene(Scene room, GameObject gameObject) {
            scenes[room].Add(gameObject);
        }

        public static List<GameObject> GetActiveObject() {
            return scenes[activeScene];
        }

        public static void LoadScene(Scene Scene) {
            isSceneChanging = true;
            StatsManager.LoadScene();
            activeScene = Scene;
            isSceneChanging = false;
        }

        public static void Update() {
            if (!isSceneChanging) {
                for (int i = 0; i < scenes[Scene.Always].Count; i++) {
                    scenes[Scene.Always][i].Update();
                }
                for (int i = 0; i < scenes[activeScene].Count; i++) {
                    scenes[activeScene][i].Update();
                }
            }
        }

        public static void Draw() {
            if (!isSceneChanging) {
                for (int lM = 0; lM < (int)LayerMask.Count; lM++) {
                    for (int gO = 0; gO < scenes[activeScene].Count; gO++) {
                        if (scenes[activeScene][gO].LayerMask == (LayerMask)lM) {
                            scenes[activeScene][gO].Draw();
                        }
                    }
                    for (int gO = 0; gO < scenes[Scene.Always].Count; gO++) {
                        if (scenes[Scene.Always][gO].LayerMask == (LayerMask)lM) {
                            scenes[Scene.Always][gO].Draw();
                        }
                    }
                }
            }
        }
    }

}
