using OpenTK;

namespace GGJam_2021
{
    static class SceneInitManager
    {
        public static void Start()
        {
            //RoomLoad();
            //AnteroomExitLoad();
            //LoungeAreaLoad();
            //KitchenLoad();
            //BathroomLoad();
            //CorridorLoad();
            //LaboratoryLoad();
            BedroomParentsLoad();

            //CentralCorridorLoad();
        }

        private static void RoomLoad()
        {
            new Background("Room", Scene.Room, new Vector2(1173, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(979, 655) };

            new Door(Scene.Room, Scene.CentralCorridor) { Position = new Vector2(984, 120) }.Scale(0.6f);

            new ColliderObject("Desk", LayerMask.Background, Scene.Room, ColliderType.BoxCollider) { Position =  new Vector2(1380, 250) }.Scale(0.3f);
            new ColliderObject("Lampada", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position =   new Vector2(1481, 980) };
            new ColliderObject("ArmadioRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position =  new Vector2(600, 998) };
            new ColliderObject("LettoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position =  new Vector2(570, 380) }.Scale(0.8f);
            new ColliderObject("SediaRoom1", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position =  new Vector2(1288, 450) }.Scale(0.5f);
            new ColliderObject("ComodinoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position =  new Vector2(800, 340) }.Scale(0.7f);

            new Portrait("Computer", LayerMask.Foreground, Scene.Room, Scene.Count, ColliderType.BoxCollider) { Position = new Vector2(1380, 210) }.Scale(0.3f);
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
            new Background("AnteroomExit", Scene.AnteroomExit, new Vector2(1241, 892)) { Position = Game.WindowCenter+ Vector2.UnitY*50, ColliderCenter = new Vector2(957, 579) }.Scale(0.8f);

            new Door(Scene.AnteroomExit, Scene.CentralCorridor) { Position = Game.WindowCenter };

            new ColliderObject("Pianta3", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position =  new Vector2(1450, 200) }.Scale(0.5f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position =  new Vector2(470, 650) }.Scale(0.9f);

            new Portrait("FamilyAlbum", LayerMask.Foreground, Scene.AnteroomExit, Scene.Count, ColliderType.BoxCollider) { Position = new Vector2(450, 500) }.Scale(0.2f);
        }

        private static void LoungeAreaLoad()
        {
            new Background("LoungeArea", Scene.LoungeArea, new Vector2(1895, 1296)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(951, 750) }.Scale(0.8f);

            new Door(Scene.LoungeArea, Scene.CentralCorridor) { Position = new Vector2(1750, 410) }.Scale(0.6f);
            new Door(Scene.LoungeArea, Scene.Bathroom) { Position = new Vector2(200, 420) }.Scale(0.6f);
            new Door(Scene.LoungeArea, Scene.Kitchen) { Position =new Vector2(713,85)}.Scale(0.6f);

            new ColliderObject("TavolaLungaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter}.Scale(0.7f);
            new ColliderObject("TvConCasseSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1180, 960) }.Scale(0.5f);
            new ColliderObject("Lampada", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1628, 1022) }.Scale(0.8f);

            new ColliderObject("SediaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(858, 642) }.Scale(0.65f);
            new ColliderObject("SediaSalone", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(1019, 418) }.Scale(0.65f);

            new ColliderObject("Sedia2Salone1", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(559, 497) }.Scale(0.65f);
            new ColliderObject("Sedia2Salone1", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(861, 411) }.Scale(0.65f);

            new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(413, 369) }.Scale(0.8f);
            new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position =  new Vector2(1074, 662) }.Scale(0.8f);

            new Portrait("PileMess", LayerMask.Middleground, Scene.LoungeArea,Scene.Count, ColliderType.BoxCollider) { Position =  new Vector2(544, 899) }.Scale(0.4f);
        }

        private static void KitchenLoad()
        {
            new Background("Kitchen", Scene.Kitchen, new Vector2(2379, 1527)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(952, 645) }.Scale(0.5f);

            new Door(Scene.Kitchen, Scene.LoungeArea) { Position = new Vector2(952, 1079) };

            new ColliderObject("tavola_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.CircleCollider) { Position =  new Vector2(560, 800) }.Scale(0.5f);
            new ColliderObject("banco_cucina_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(1222, 305) }.Scale(0.5f);

            new Portrait("Whiskey", LayerMask.Foreground, Scene.Kitchen, Scene.Count, ColliderType.BoxCollider) { Position =new Vector2(603, 815) }.Scale(0.15f);
            new Fridge( Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(484, 349)}.Scale(0.5f);

        }

        private static void BathroomLoad()
        {
            new Background("Bathroom", Scene.Bathroom, new Vector2(1273, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(1015, 660) }.Scale(0.8f);

            new Door(Scene.Bathroom, Scene.LoungeArea) { Position = new Vector2(1287, 1079) };

            new ColliderObject("CessoBidet", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(570, 800) }.Scale(0.6f);
            new ColliderObject("LavandinoCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(1320, 340) }.Scale(0.7f);
            new ColliderObject("DoppioCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position =  new Vector2(630, 250) }.Scale(0.8f);

            new Portrait("Retched", LayerMask.Background, Scene.Bathroom,Scene.Count,ColliderType.BoxCollider) { Position =  new Vector2(700, 840) }.Scale(0.5f);

        }

        private static void CorridorLoad()
        {
            new Background("Corridor", Scene.Corridor, new Vector2(1622, 484)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(835, 621) };

            new Door(Scene.Corridor, Scene.CentralCorridor) { Position = new Vector2(100, 500) };
            new Door(Scene.Corridor, Scene.Laboratory) { Position = new Vector2(1267, 180) }.Scale(0.8f);
            new Door(Scene.Corridor, Scene.BedroomParents) { Position = new Vector2(680, 1013) };

            new ColliderObject("Pianta1", LayerMask.Middleground, Scene.Corridor, ColliderType.BoxCollider) { Position = new Vector2(1567, 341) }.Scale(0.5f);
        }

        private static void LaboratoryLoad()
        {
            new Background("Laboratory", Scene.Laboratory, new Vector2(1883, 1040)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(954, 600) }.Scale(0.7f);

            new Door(Scene.Laboratory, Scene.Corridor) { Position = new Vector2(950, 1068) };

            new ColliderObject("TavoloDaLavoroLaboratory", LayerMask.Background, Scene.Laboratory, ColliderType.BoxCollider) { Position =  new Vector2(366, 530) }.Scale(0.65f);
            new ColliderObject("ScaffaleDaLavoroLaboratory", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position =  new Vector2(506, 180) }.Scale(1.2f);
            new ColliderObject("chitarra_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(900, 280) }.Scale(0.8f);
            new ColliderObject("batteria_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position =  new Vector2(1229, 320) }.Scale(0.5f);

            new Portrait("Guitar", LayerMask.Middleground, Scene.Laboratory, Scene.Count, ColliderType.BoxCollider) { Position = new Vector2(435, 660) }.Scale(0.25f);

        }

        private static void BedroomParentsLoad()
        {
            new Background("BedroomParents", Scene.BedroomParents, new Vector2(1631, 984)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(920, 620) }.Scale(0.7f);

            new Door(Scene.BedroomParents, Scene.Corridor) { Position = new Vector2(700, 130) }.Scale(0.55f);

            new ColliderObject("letto_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position =  new Vector2(1280, 700) }.Scale(0.75f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position =  new Vector2(360, 640) }.Scale(0.5f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position =  new Vector2(360, 900) }.Scale(0.5f);
            new ColliderObject("mobile_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position =  new Vector2(1197, 299) }.Scale(0.5f);
            new ColliderObject("Pianta2", LayerMask.Middleground, Scene.BedroomParents, ColliderType.CircleCollider) { Position = new Vector2(400, 270) }.Scale(0.3f);

            new Portrait("FramedFamilyPhoto", LayerMask.Middleground, Scene.BedroomParents, Scene.Count, ColliderType.BoxCollider) { Position =  new Vector2(1210, 260) }.Scale(0.2f);
        }
    }
}
