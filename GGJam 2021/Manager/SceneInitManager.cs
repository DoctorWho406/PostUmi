using OpenTK;

namespace GGJam_2021 {
    static class SceneInitManager {
        public static void Start() {
            RoomLoad();
            LondeAreaLoad();
            CentralCorridorLoad();
            AnteroomExit();
            KitchenLoad();
            BathroomLoad();
            CorridorLoad();
            LaboratoryLoad();
            BedroomParentsLoad();
        }

        private static void RoomLoad() {
            //new Background("Room", Scene.Room) { Position = Game.WindowCenter};
            new Door("FrontDoor", Scene.Room, Scene.CentralCorridor) { Position = Game.WindowCenter };
        }

        private static void CentralCorridorLoad() {
            //new Background("CentralCorridor", Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter + Vector2.UnitX * -300 };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.AnteroomExit) { Position = Game.WindowCenter + Vector2.UnitY * -300 };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.Corridor) { Position = Game.WindowCenter + Vector2.UnitX * 300 };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.Room) { Position = Game.WindowCenter + Vector2.UnitY * +300 };
        }

        private static void AnteroomExit() {
            //new Background("AnteroomExit", Scene.AnteroomExit) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.AnteroomExit, Scene.CentralCorridor) { Position = Game.WindowCenter };
            //new Door("FrontDoor", Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter };
        }

        private static void LondeAreaLoad() {
            //new Background("LoungeArea", Scene.LoungeArea) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.Bathroom) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.Kitchen) { Position = Game.WindowCenter };
        }

        private static void KitchenLoad() {
            //new Background("Kitchen", Scene.Kitchen) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Kitchen, Scene.LoungeArea) { Position = Game.WindowCenter };
        }

        private static void BathroomLoad() {
            //new Background("Bathroom", Scene.Bathroom) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Bathroom, Scene.LoungeArea) { Position = Game.WindowCenter };
        }

        private static void CorridorLoad() {
            //new Background("Corridor", Scene.Corridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.Laboratory) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.BedroomParents) { Position = Game.WindowCenter };
        }

        private static void LaboratoryLoad() {
            //new Background("Laboratory", Scene.Laboratory) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Laboratory, Scene.Corridor) { Position = Game.WindowCenter };
        }

        private static void BedroomParentsLoad() {
            //new Background("BedroomParents", Scene.BedroomParents) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.BedroomParents, Scene.Corridor) { Position = Game.WindowCenter };
        }
    }
}
