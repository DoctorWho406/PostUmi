using OpenTK;

namespace GGJam_2021
{
    static class SceneInitManager
    {
        public static void Start()
        {
            RoomLoad();
            LooungeAreaLoad();
            CentralCorridorLoad();
            AnteroomExitLoad();
            KitchenLoad();
            BathroomLoad();
            CorridorLoad();
            LaboratoryLoad();
            BedroomParentsLoad();
        }

        private static void RoomLoad()
        {
            new Background("Room", Scene.Room, new Vector2(1173, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(979, 629) }.Scale(0.7f);
            new Door(Scene.Room, Scene.CentralCorridor) { Position = Game.WindowCenter }.Scale(0.5f);
            new ColliderObject("SediaRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("Lampada", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("ComodinoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("ArmadioRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("LettoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
        }

        private static void CentralCorridorLoad()
        {
            new Background("CentralCorridor", Scene.CentralCorridor, new Vector2(2175, 485)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(976, 736) };
            new Door(Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter + Vector2.UnitX * -300 };
            new Door(Scene.CentralCorridor, Scene.AnteroomExit) { Position = Game.WindowCenter + Vector2.UnitY * -300 };
            new Door(Scene.CentralCorridor, Scene.Corridor) { Position = Game.WindowCenter + Vector2.UnitX * 300 };
            new Door(Scene.CentralCorridor, Scene.Room) { Position = Game.WindowCenter + Vector2.UnitY * +300 };
        }

        private static void AnteroomExitLoad()
        {
            new Background("AnteroomExit", Scene.AnteroomExit, new Vector2(1241, 892)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(957, 579) };
            new Door(Scene.AnteroomExit, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new ColliderObject("Pianta2", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("ScaffaleDaLavoroLaboratory", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
          
        }

        private static void LooungeAreaLoad()
        {
            new Background("LoungeArea", Scene.LoungeArea, new Vector2(1895, 1296)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(951, 817) };
            new Door(Scene.LoungeArea, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door(Scene.LoungeArea, Scene.Bathroom) { Position = Game.WindowCenter };
            new Door(Scene.LoungeArea, Scene.Kitchen) { Position = Game.WindowCenter };
            new ColliderObject("TavolaLungaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("SediaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject(" TvConCasseSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject(" Lampada", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new InteractableObject(" PileMess", LayerMask.Middleground, Scene.LoungeArea,Scene.Count, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject(" Sedia2Salone1", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
        }

        private static void KitchenLoad()
        {
            new Background("Kitchen", Scene.Kitchen, new Vector2(2379, 1527)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(952, 725) };
            new Door(Scene.Kitchen, Scene.LoungeArea) { Position = Game.WindowCenter };
            new ColliderObject("SediaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new ColliderObject("Sedia2Salone1", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);

        }

        private static void BathroomLoad()
        {
            new Background("Bathroom", Scene.Bathroom, new Vector2(1273, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(1024, 695) };
            new Door(Scene.Bathroom, Scene.LoungeArea) { Position = Game.WindowCenter };
        }

        private static void CorridorLoad()
        {
            new Background("Corridor", Scene.Corridor, new Vector2(1622, 484)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(835, 621) };
            new ColliderObject("Pianta1", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = Game.WindowCenter + new Vector2(600, 300) }.Scale(0.5f);
            new Door(Scene.Corridor, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door(Scene.Corridor, Scene.Laboratory) { Position = Game.WindowCenter };
            new Door(Scene.Corridor, Scene.BedroomParents) { Position = Game.WindowCenter };
        }

        private static void LaboratoryLoad()
        {
            new Background("Laboratory", Scene.Laboratory, new Vector2(1883, 1296)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(954, 627) };
            new Door(Scene.Laboratory, Scene.Corridor) { Position = Game.WindowCenter };
        }

        private static void BedroomParentsLoad()
        {
            new Background("BedroomParents", Scene.BedroomParents, new Vector2(1631, 964)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(970, 645) };
            new Door(Scene.BedroomParents, Scene.Corridor) { Position = Game.WindowCenter };
        }
    }
}
