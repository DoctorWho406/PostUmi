using OpenTK;

namespace GGJam_2021 {
    static class SceneInitManager {
        public static void Start() {
            Dialogue();
            RoomLoad();
            KitchenLoad();
            BathroomLoad();
            CorridorLoad();
            LoungeAreaLoad();
            LaboratoryLoad();
            AnteroomExitLoad();
            BedroomParentsLoad();
            CentralCorridorLoad();
            Door();
            PortraitLoad();
            GameMenuLoad();
        }

        private static void PortraitLoad() {
            Portrait portrait1 = new Portrait("Whiskey", LayerMask.Foreground, Scene.Kitchen, Scene.DialogueAlcol, ColliderType.BoxCollider) { Position = new Vector2(618, 830/*603, 815*/) };
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

        private static void Door() {
            Door Room_Central = new Door("FrontDoor", Scene.Room, Scene.CentralCorridor, new Vector2(993, 325), 390) { Position = new Vector2(984, 120) };
            Door Central_Room = new Door("BackDoor", Scene.CentralCorridor, Scene.Room, new Vector2(984, 917), 390, true, LayerMask.Foreground) { Position = new Vector2(993, 900) };

            Door Central_Lounge = new Door("Empty", Scene.CentralCorridor, Scene.LoungeArea, new Vector2(183, 723)) { Position = new Vector2(2, 715) };
            Door Lounge_Central = new Door("Empty", Scene.LoungeArea, Scene.CentralCorridor, new Vector2(1552, 410)) { Position = new Vector2(1750, 410) };

            Door Central_Corridor = new Door("Empty", Scene.CentralCorridor, Scene.Corridor, new Vector2(1904, 752)) { Position = new Vector2(1904, 752) };
            Door Corridor_Central = new Door("Empty", Scene.Corridor, Scene.CentralCorridor, new Vector2(100, 500)) { Position = new Vector2(100, 500) };

            Door Central_Anteroom = new Door("Empty", Scene.CentralCorridor, Scene.AnteroomExit, new Vector2(1100, 536)) { Position = new Vector2(1114, 306) };
            Door Anteroom_Central = new Door("Empty", Scene.AnteroomExit, Scene.CentralCorridor, new Vector2(993, 879)) { Position = new Vector2(967, 1052) };
            new EndDoor(67) { Position = new Vector2(967, 110) }.Scale(3.5f);

            Door Lounge_Kitchen = new Door("FrontDoor", Scene.LoungeArea, Scene.Kitchen, new Vector2(713, 278), 390) { Position = new Vector2(750, 85) };
            Door Kitchen_Lounge = new Door("BackDoor", Scene.Kitchen, Scene.LoungeArea, new Vector2(967, 970), 390, true, LayerMask.Foreground) { Position = new Vector2(952, 900) };

            Door Lounge_Bathroom = new Door("FrontDoor", Scene.LoungeArea, Scene.Bathroom, new Vector2(1520, 284), 390, true) { Position = new Vector2(1537, 85) };
            Door Bathroom_Lounge = new Door("BackDoor", Scene.Bathroom, Scene.LoungeArea, new Vector2(1224, 975), 390, true, LayerMask.Foreground) { Position = new Vector2(1287, 970) };

            Door Corridor_Parents = new Door("BackDoor", Scene.Corridor, Scene.BedroomParents, new Vector2(700, 700), 390, true, LayerMask.Foreground) { Position = new Vector2(680, 800) };
            Door Parents_Corrido = new Door("FrontDoor", Scene.BedroomParents, Scene.Corridor, new Vector2(680, 130), 390) { Position = new Vector2(700, 130) };

            Door Corridor_Lab = new Door("FrontDoor", Scene.Corridor, Scene.Laboratory, new Vector2(1267, 180), 390) { Position = new Vector2(1267, 180) };
            Door Lab_Corridor = new Door("BackDoor", Scene.Laboratory, Scene.Corridor, new Vector2(950, 950), 390, true, LayerMask.Foreground) { Position = new Vector2(950, 900) };

            Parents_Corrido.Scale(0.55f);
            Lab_Corridor.Scale(0.7f);
            Corridor_Parents.Scale(0.7f);
            Corridor_Central.Scale(0.7f);
            Corridor_Lab.Scale(0.8f);
            Bathroom_Lounge.Scale(0.7f);
            Kitchen_Lounge.Scale(0.7f);
            Room_Central.Scale(0.6f);
            Lounge_Central.Scale(0.6f);
            Central_Room.Scale(0.7f);
            Central_Lounge.Scale(0.7f);
            Central_Corridor.Scale(0.7f);
            Central_Anteroom.Scale(0.7f);
            Lounge_Kitchen.Scale(0.6f);
            Lounge_Bathroom.Scale(0.6f);

            Room_Central.SetNextDoor(Central_Room);

            Central_Room.SetNextDoor(Room_Central);
            Central_Lounge.SetNextDoor(Lounge_Central);
            Central_Anteroom.SetNextDoor(Anteroom_Central);
            Central_Corridor.SetNextDoor(Corridor_Central);

            Lounge_Central.SetNextDoor(Central_Lounge);
            Lounge_Bathroom.SetNextDoor(Bathroom_Lounge);
            Lounge_Kitchen.SetNextDoor(Kitchen_Lounge);

            Kitchen_Lounge.SetNextDoor(Lounge_Kitchen);

            Bathroom_Lounge.SetNextDoor(Lounge_Bathroom);

            Anteroom_Central.SetNextDoor(Central_Anteroom);

            Corridor_Central.SetNextDoor(Central_Corridor);
            Corridor_Lab.SetNextDoor(Lab_Corridor);
            Corridor_Parents.SetNextDoor(Parents_Corrido);

            Parents_Corrido.SetNextDoor(Corridor_Parents);

            Lab_Corridor.SetNextDoor(Corridor_Lab);
        }
        private static void RoomLoad() {
            new Background("Room", Scene.Room, new Vector2(1173, 858)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(979, 655) };
            new ColliderObject("Lampada", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1481, 980) };
            new ColliderObject("ArmadioRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(600, 998) };
            new ColliderObject("Desk", LayerMask.Background, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1380, 280) }.Scale(0.3f);
            new ColliderObject("LettoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(570, 380) }.Scale(0.8f);
            new ColliderObject("SediaRoom1", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(1288, 450) }.Scale(0.5f);
            new ColliderObject("ComodinoRoom", LayerMask.Middleground, Scene.Room, ColliderType.BoxCollider) { Position = new Vector2(800, 340) }.Scale(0.7f);
        }

        private static void CentralCorridorLoad() {
            new Background("CentralCorridor", Scene.CentralCorridor, new Vector2(2175, 540)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(976, 730) };
        }

        private static void AnteroomExitLoad() {
            new Background("AnteroomExit", Scene.AnteroomExit, new Vector2(1241, 950)) { Position = Game.WindowCenter + Vector2.UnitY * 50, ColliderCenter = new Vector2(957, 590) }.Scale(0.8f);
            new ColliderObject("Pianta3", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = new Vector2(1350, 200) }.Scale(0.35f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.AnteroomExit, ColliderType.BoxCollider) { Position = new Vector2(470, 650) }.Scale(0.7f);
        }

        private static void LoungeAreaLoad() {
            new Background("LoungeArea", Scene.LoungeArea, new Vector2(1895, 1300)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(951, 750) }.Scale(0.8f);

            new ColliderObject("Lampada", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1628, 1022) }.Scale(0.8f);
            new ColliderObject("SediaSalone", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1019, 418) }.Scale(0.65f);
            new ColliderObject("SediaSalone", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(858, 642) }.Scale(0.65f);
            new ColliderObject("Sedia2Salone1", LayerMask.Background, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(861, 411) }.Scale(0.65f);
            new ColliderObject("TavolaLungaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = Game.WindowCenter }.Scale(0.7f);
            new ColliderObject("Sedia2Salone1", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(559, 497) }.Scale(0.65f);
            new ColliderObject("TvConCasseSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1180, 960) }.Scale(0.5f);
            new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(413, 369) }.Scale(0.8f);
            new ColliderObject("SediaCadutaSalone", LayerMask.Middleground, Scene.LoungeArea, ColliderType.BoxCollider) { Position = new Vector2(1074, 662) }.Scale(0.8f);
        }

        private static void KitchenLoad() {
            new Background("Kitchen", Scene.Kitchen, new Vector2(2379, 1640)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(952, 670) }.Scale(0.5f);

            new Fridge(Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(484, 349) }.Scale(0.5f);

            new ColliderObject("tavola_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.CircleCollider) { Position = new Vector2(560, 800) }.Scale(0.5f);
            new ColliderObject("banco_cucina_kitchen", LayerMask.Middleground, Scene.Kitchen, ColliderType.BoxCollider) { Position = new Vector2(1222, 305) }.Scale(0.5f);
        }

        private static void BathroomLoad() {
            new Background("Bathroom", Scene.Bathroom, new Vector2(1273, 900)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(1015, 690) }.Scale(0.8f);

            new ColliderObject("CessoBidet", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(570, 800) }.Scale(0.6f);
            new ColliderObject("DoppioCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(630, 250) }.Scale(0.8f);
            new ColliderObject("LavandinoCesso", LayerMask.Middleground, Scene.Bathroom, ColliderType.BoxCollider) { Position = new Vector2(1320, 340) }.Scale(0.7f);
        }

        private static void CorridorLoad() {
            new Background("Corridor", Scene.Corridor, new Vector2(1622, 500)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(835, 621) };

            new ColliderObject("Pianta1", LayerMask.Middleground, Scene.Corridor, ColliderType.BoxCollider) { Position = new Vector2(1567, 341) }.Scale(0.5f);
        }

        private static void LaboratoryLoad() {
            new Background("Laboratory", Scene.Laboratory, new Vector2(1883, 1150)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(954, 600) }.Scale(0.7f);

            new ColliderObject("chitarra_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(900, 280) }.Scale(0.8f);
            new ColliderObject("batteria_laboratorio", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(1229, 320) }.Scale(0.5f);
            new ColliderObject("TavoloDaLavoroLaboratory", LayerMask.Background, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(366, 530) }.Scale(0.65f);
            new ColliderObject("ScaffaleDaLavoroLaboratory", LayerMask.Middleground, Scene.Laboratory, ColliderType.BoxCollider) { Position = new Vector2(506, 180) }.Scale(1.2f);
        }

        private static void BedroomParentsLoad() {
            new Background("BedroomParents", Scene.BedroomParents, new Vector2(1631, 984)) { Position = Game.WindowCenter, ColliderCenter = new Vector2(920, 620) }.Scale(0.7f);

            new ColliderObject("Pianta2", LayerMask.Middleground, Scene.BedroomParents, ColliderType.CircleCollider) { Position = new Vector2(420, 260) }.Scale(0.3f);
            new ColliderObject("letto_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(1280, 700) }.Scale(0.75f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(360, 630) }.Scale(0.6f);
            new ColliderObject("armadio_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(360, 800) }.Scale(0.6f);
            new ColliderObject("mobile_bedroom_parents", LayerMask.Middleground, Scene.BedroomParents, ColliderType.BoxCollider) { Position = new Vector2(1197, 299) }.Scale(0.5f);
        }

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

            new Portrait("Dino", LayerMask.Background, Scene.DialogueDino, Scene.Room, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Alcol", LayerMask.Background, Scene.DialogueAlcol, Scene.Kitchen, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Vomito", LayerMask.Background, Scene.DialogueVomito, Scene.Bathroom, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("Foto", LayerMask.Background, Scene.DialogueFoto, Scene.BedroomParents, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("Album", LayerMask.Background, Scene.DialogueAlbum, Scene.AnteroomExit, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };
            new Portrait("Bordello", LayerMask.Background, Scene.DialogueBordello, Scene.LoungeArea, ColliderType.BoxCollider, 9, 5, 700) { Position = Game.WindowCenter };
            new Portrait("Chitarra", LayerMask.Background, Scene.DialogueChitarra, Scene.Laboratory, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("ComputerPortrait", LayerMask.Background, Scene.DialogueComputer, Scene.Room, ColliderType.BoxCollider, 3, 5, 700) { Position = Game.WindowCenter };
            new Portrait("BloccoDisegni", LayerMask.Background, Scene.DialogueBloccoDisegni, Scene.Laboratory, ColliderType.BoxCollider, 18, 3, 700) { Position = Game.WindowCenter };

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

        private static void GameMenuLoad() {
            new Button("BadEnd", Scene.BadEndGame, Scene.Menu, ColliderType.BoxCollider) { Position = Game.WindowCenter };
            new Button("PlayButton", Scene.Menu,Scene.Room,ColliderType.CircleCollider) { Position = new Vector2(741, 771) }.Scale(1.2f);
            new Button("QuitButton", Scene.Menu,Scene.BadEndGame, ColliderType.CircleCollider) { Position = new Vector2(961, 728) }.Scale(1.2f);
            //new Button(/*GoodEnd*/, Scene.GoodEndGame, Scene.Menu, ColliderType.BoxCollider) { Position = Game.WindowCenter };//da mettere lo sprite del good end
            new Background("Menu", Scene.Menu, new Vector2(Game.Window.Width, Game.Window.Height)) { Position = (Game.WindowCenter), ColliderCenter = Game.WindowCenter };
        }
    }
}

