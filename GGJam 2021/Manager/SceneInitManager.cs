using OpenTK;

namespace GGJam_2021 {
    static class SceneInitManager {
        public static void Start() {
            Dialogue();
            RoomLoad();
            //KitchenLoad();
            //BathroomLoad();
            //CorridorLoad();
            //LoungeAreaLoad();
            //LaboratoryLoad();
            //AnteroomExitLoad();
            //BedroomParentsLoad();
            //CentralCorridorLoad();
            //Portrait();
        }
        #region Stanze

        private static void Portrait() {
            Portrait portrait1 = new Portrait("Whiskey", LayerMask.Foreground, Scene.Kitchen, Scene.DialogueAlcol, ColliderType.BoxCollider) { Position = new Vector2(603, 815) };
            portrait1.Scale(0.15f);
            Portrait portrait2 = new Portrait("Retched", LayerMask.Background, Scene.Bathroom, Scene.DialogueVomito, ColliderType.BoxCollider) { Position = new Vector2(700, 840) };
            portrait2.Scale(0.5f);
            Portrait portrait3 = new Portrait("PileMess", LayerMask.Middleground, Scene.LoungeArea, Scene.DialogueBordello, ColliderType.BoxCollider) { Position = new Vector2(544, 899) };
            portrait3.Scale(0.4f);
            Portrait portrait4 = new Portrait("Computer", LayerMask.Foreground, Scene.Room, Scene.DialogueComputer, ColliderType.BoxCollider) { Position = new Vector2(1380, 210) };
            portrait4.Scale(0.3f);
            Portrait portrait5 = new Portrait("FamilyAlbum", LayerMask.Foreground, Scene.AnteroomExit, Scene.DialogueAlbum, ColliderType.BoxCollider) { Position = new Vector2(450, 600) };
            portrait5.Scale(0.15f);
            Portrait portrait6 = new Portrait("Guitar", LayerMask.Middleground, Scene.Laboratory, Scene.DialogueChitarra, ColliderType.BoxCollider) { Position = new Vector2(435, 660) };
            portrait6.Scale(0.25f);
            Portrait portrait7 = new Portrait("Sketchbooketched", LayerMask.Foreground, Scene.Laboratory, Scene.DialogueBloccoDisegni, ColliderType.BoxCollider) { Position = new Vector2(366, 530) };
            portrait7.Scale(0.25f);
            Portrait portrait8 = new Portrait("Actionfigure", LayerMask.Foreground, Scene.Room, Scene.DialogueDino, ColliderType.BoxCollider) { Position = new Vector2(570, 380) };
            portrait8.Scale(0.3f);
            Portrait portrait9 = new Portrait("FramedFamilyPhoto", LayerMask.Middleground, Scene.BedroomParents, Scene.DialogueFoto, ColliderType.BoxCollider) { Position = new Vector2(1210, 260) };
            portrait9.Scale(0.2f);


            InteractableObjectManager.AddPortarait(portrait1, null);
            InteractableObjectManager.AddPortarait(portrait2, portrait1);
            InteractableObjectManager.AddPortarait(portrait3, portrait2);
            InteractableObjectManager.AddPortarait(portrait4, portrait3);
            InteractableObjectManager.AddPortarait(portrait5, portrait4);
            InteractableObjectManager.AddPortarait(portrait6, portrait5);
            InteractableObjectManager.AddPortarait(portrait7, portrait6);
            InteractableObjectManager.AddPortarait(portrait8, portrait7);
            InteractableObjectManager.AddPortarait(portrait9, portrait8);
        }

        private static void RoomLoad() {
            new Background("Room", Scene.Room, new Vector2(1173, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(979, 655) };

            //new Door(Scene.Room, Scene.CentralCorridor) { Position = new Vector2(984, 120) }.Scale(0.6f);

            new ColliderObject("Lampada", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1481, 980) };
            new ColliderObject("ArmadioRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(600, 998) };
            new ColliderObject("Desk", LayerMask.Background, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1380, 250) }.Scale(0.3f);
            new ColliderObject("LettoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(570, 380) }.Scale(0.8f);
            new ColliderObject("SediaRoom1", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1288, 450) }.Scale(0.5f);
            new ColliderObject("ComodinoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(800, 340) }.Scale(0.7f);

        }

        //private static void CentralCorridorLoad() {
        //    new Background("CentralCorridor", Scene.CentralCorridor, new Vector2(2175, 485)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(976, 736) };

        //    new Door(Scene.CentralCorridor, Scene.Room) { Position = new Vector2(993, 1067) }.Scale(0.7f);
        //    new Door(Scene.CentralCorridor, Scene.LoungeArea) { Position = new Vector2(2, 715) }.Scale(0.7f);
        //    new Door(Scene.CentralCorridor, Scene.Corridor) { Position = new Vector2(1904, 752) }.Scale(0.7f);
        //    new Door(Scene.CentralCorridor, Scene.AnteroomExit) { Position = new Vector2(1186, 400) }.Scale(0.7f);
        //}

        //private static void AnteroomExitLoad() {
        //    new Background("AnteroomExit", Scene.AnteroomExit, new Vector2(1241, 892)) { Position = Game.WindowCenter + Vector2.UnitY * 50, ColliderCenter = new Vector2(957, 579) }.Scale(0.8f);

        //    new Door(Scene.AnteroomExit, Scene.CentralCorridor) { Position = Game.WindowCenter + Vector2.UnitY * 600 };

        //    new ColliderObject("Pianta3", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = new Vector2(1350, 200) }.Scale(0.35f);
        //    new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = new Vector2(470, 650) }.Scale(0.7f);

        //}

        //private static void LoungeAreaLoad() {
        //    new Background("LoungeArea", Scene.LoungeArea, new Vector2(1895, 1296)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(951, 750) }.Scale(0.8f);

        //    new Door(Scene.LoungeArea, Scene.Kitchen) { Position = new Vector2(713, 85) }.Scale(0.6f);
        //    new Door(Scene.LoungeArea, Scene.Bathroom) { Position = new Vector2(200, 420) }.Scale(0.6f);
        //    new Door(Scene.LoungeArea, Scene.CentralCorridor) { Position = new Vector2(1750, 410) }.Scale(0.6f);

        //    new ColliderObject("Lampada", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1628, 1022) }.Scale(0.8f);
        //    new ColliderObject("SediaSalone", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1019, 418) }.Scale(0.65f);
        //    new ColliderObject("SediaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(858, 642) }.Scale(0.65f);
        //    new ColliderObject("Sedia2Salone1", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(861, 411) }.Scale(0.65f);
        //    new ColliderObject("TavolaLungaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter }.Scale(0.7f);
        //    new ColliderObject("Sedia2Salone1", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(559, 497) }.Scale(0.65f);
        //    new ColliderObject("TvConCasseSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1180, 960) }.Scale(0.5f);
        //    new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(413, 369) }.Scale(0.8f);
        //    new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1074, 662) }.Scale(0.8f);

        //}

        //private static void KitchenLoad() {
        //    new Background("Kitchen", Scene.Kitchen, new Vector2(2379, 1527)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(952, 645) }.Scale(0.5f);

        //    new Door(Scene.Kitchen, Scene.LoungeArea) { Position = new Vector2(952, 1079) };
        //    new Fridge(Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(484, 349) }.Scale(0.5f);

        //    new ColliderObject("tavola_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.CircleCollider) { Position = new Vector2(560, 800) }.Scale(0.5f);
        //    new ColliderObject("banco_cucina_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(1222, 305) }.Scale(0.5f);
        //}

        //private static void BathroomLoad() {
        //    new Background("Bathroom", Scene.Bathroom, new Vector2(1273, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(1015, 660) }.Scale(0.8f);

        //    new Door(Scene.Bathroom, Scene.LoungeArea) { Position = new Vector2(1287, 1079) };

        //    new ColliderObject("CessoBidet", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(570, 800) }.Scale(0.6f);
        //    new ColliderObject("DoppioCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(630, 250) }.Scale(0.8f);
        //    new ColliderObject("LavandinoCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(1320, 340) }.Scale(0.7f);
        //}

        //private static void CorridorLoad() {
        //    new Background("Corridor", Scene.Corridor, new Vector2(1622, 484)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(835, 621) };

        //    new Door(Scene.Corridor, Scene.CentralCorridor) { Position = new Vector2(100, 500) };
        //    new Door(Scene.Corridor, Scene.BedroomParents) { Position = new Vector2(680, 1013) };
        //    new Door(Scene.Corridor, Scene.Laboratory) { Position = new Vector2(1267, 180) }.Scale(0.8f);

        //    new ColliderObject("Pianta1", LayerMask.Middleground, Scene.Corridor, ColliderType.BoxCollider) { Position = new Vector2(1567, 341) }.Scale(0.5f);
        //}

        //private static void LaboratoryLoad() {
        //    new Background("Laboratory", Scene.Laboratory, new Vector2(1883, 1040)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(954, 600) }.Scale(0.7f);

        //    new Door(Scene.Laboratory, Scene.Corridor) { Position = new Vector2(950, 1068) };

        //    new ColliderObject("chitarra_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(900, 280) }.Scale(0.8f);
        //    new ColliderObject("batteria_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(1229, 320) }.Scale(0.5f);
        //    new ColliderObject("TavoloDaLavoroLaboratory", LayerMask.Background, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(366, 530) }.Scale(0.65f);
        //    new ColliderObject("ScaffaleDaLavoroLaboratory", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(506, 180) }.Scale(1.2f);
        //}

        //private static void BedroomParentsLoad() {
        //    new Background("BedroomParents", Scene.BedroomParents, new Vector2(1631, 984)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(920, 620) }.Scale(0.7f);

        //    new Door(Scene.BedroomParents, Scene.Corridor) { Position = new Vector2(700, 130) }.Scale(0.55f);

        //    new ColliderObject("Pianta2", LayerMask.Middleground, Scene.BedroomParents, ColliderType.CircleCollider) { Position = new Vector2(420, 260) }.Scale(0.3f);
        //    new ColliderObject("letto_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(1280, 700) }.Scale(0.75f);
        //    new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(360, 630) }.Scale(0.6f);
        //    new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(360, 800) }.Scale(0.6f);
        //    new ColliderObject("mobile_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(1197, 299) }.Scale(0.5f);
        //}
        #endregion
        private static void Dialogue() {
            new UIText("whiskey", Scene.DialogueAlcol) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("vomito", Scene.DialogueVomito) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("bordello", Scene.DialogueBordello) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("fotoricordo", Scene.DialogueFoto) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("actionfigure", Scene.DialogueDino) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("albumdifoto", Scene.DialogueAlbum) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("chitarra", Scene.DialogueChitarra) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("computer", Scene.DialogueComputer) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);
            new UIText("bloccodisegno", Scene.DialogueBloccoDisegni) { Position = new Vector2(Game.WindowCenter.X, 900) }.Scale(0.75f);

            new Portrait("Alcol", LayerMask.Background, Scene.DialogueAlcol, Scene.Kitchen, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Vomito", LayerMask.Background, Scene.DialogueVomito, Scene.Bathroom, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("Bordello", LayerMask.Background, Scene.DialogueBordello, Scene.LoungeArea, ColliderType.BoxCollider, 9, 5, 700) { Position = Game.WindowCenter };
            new Portrait("ComputerPortrait", LayerMask.Background, Scene.DialogueComputer, Scene.Room, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("Album", LayerMask.Background, Scene.DialogueAlbum, Scene.AnteroomExit, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Chitarra", LayerMask.Background, Scene.DialogueChitarra, Scene.Laboratory, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("BloccoDisegni", LayerMask.Background, Scene.DialogueBloccoDisegni, Scene.Laboratory, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Dino", LayerMask.Background, Scene.DialogueDino, Scene.Room, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Foto", LayerMask.Background, Scene.DialogueFoto, Scene.BedroomParents, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };

            new Background("sfondo", Scene.DialogueDino, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueFoto, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueAlbum, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueAlcol, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueVomito, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueBordello, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueChitarra, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueComputer, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
            new Background("sfondo", Scene.DialogueBloccoDisegni, new Vector2(1759, 325)) { Position = new Vector2(Game.WindowCenter.X, 900), ColliderCenter = new Vector2(Game.WindowCenter.X * 0.5f, 450) };
        }
    }
}

