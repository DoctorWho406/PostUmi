using System.Collections.Generic;
using OpenTK;

namespace GGJam_2021 {
    enum Scene {
        Menu,
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
        BadEndGame,
        GoodEndGame,

        DialogueAlbum,
        DialogueAlcol,
        DialogueBloccoDisegni,
        DialogueBordello,
        DialogueChitarra,
        DialogueComputer,
        DialogueDino,
        DialogueFoto,
        DialogueVomito,
        Count
    }

    static class SceneManager {
        public static bool IsSceneChanging {
            get; private set;
        }

        public static Scene ActiveScene {
            get; private set;
        }

        private static Dictionary<Scene, List<GameObject>> scenes;

        static SceneManager() {
            IsSceneChanging = false;
            ActiveScene = Constants.StartingScene;
            scenes = new Dictionary<Scene, List<GameObject>>();
            for (int s = 0; s < (int)Scene.Count; s++) {
                scenes[(Scene)s] = new List<GameObject>();
            }
        }

        public static void AddGOToScene(Scene room, GameObject gameObject) {
            scenes[room].Add(gameObject);
        }

        public static List<GameObject> GetActiveObject() {
            return scenes[ActiveScene];
        }

        public static void LoadScene(Scene scene) {
            IsSceneChanging = true;
            if ((scene == Scene.DialogueAlbum)
                && (scene == Scene.DialogueAlcol)
                && (scene == Scene.DialogueBloccoDisegni)
                && (scene == Scene.DialogueBordello)
                && (scene == Scene.DialogueChitarra)
                && (scene == Scene.DialogueComputer)
                && (scene == Scene.DialogueDino)
                && (scene == Scene.DialogueFoto)
                && (scene == Scene.DialogueVomito)
                && (scene == Scene.Menu)
                && (scene == Scene.BadEndGame)) {
                Game.Player.IsVisible = false;
            } else {
                Game.Player.IsVisible = true;
            }
            StatsManager.LoadScene();
            ActiveScene = scene;
            IsSceneChanging = false;
        }

        public static void LoadScene(Scene scene, Vector2 playerPosition) {
            IsSceneChanging = true;
            Game.Player.Position = playerPosition;
            StatsManager.LoadScene();
            ActiveScene = scene;
            IsSceneChanging = false;
        }

        public static void Update() {
            if (!IsSceneChanging) {
                for (int i = 0; i < scenes[Scene.Always].Count; i++) {
                    scenes[Scene.Always][i].Update();
                }
                for (int i = 0; i < scenes[ActiveScene].Count; i++) {
                    scenes[ActiveScene][i].Update();
                }
            }
        }

        public static void Draw() {
            if (!IsSceneChanging) {
                for (int lM = 0; lM < (int)LayerMask.Count; lM++) {
                    for (int gO = 0; gO < scenes[ActiveScene].Count; gO++) {
                        if (scenes[ActiveScene][gO].LayerMask == (LayerMask)lM) {
                            scenes[ActiveScene][gO].Draw();
                        }
                    }
                    for (int gO = 0; gO < scenes[Scene.Always].Count; gO++) {
                        if (scenes[Scene.Always][gO] is Player) {
                            if (((Player)scenes[Scene.Always][gO]).IsVisible) {
                                if (scenes[Scene.Always][gO].LayerMask == (LayerMask)lM) {
                                    scenes[Scene.Always][gO].Draw();
                                }
                            }
                        } else {
                            if (scenes[Scene.Always][gO].LayerMask == (LayerMask)lM) {
                                scenes[Scene.Always][gO].Draw();
                            }
                        }
                    }
                }
            }
        }
    }

}
