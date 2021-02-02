namespace GGJam_2021 {
    static class TextureInitManager {
        public static void Start() {
            //Background
            ////Room
            TextureManager.AddTexture("Room", Constants.BackgroundDirectory + "Room.png");
            TextureManager.AddTexture("Computer", Constants.ItemsDirectory + "Computer.png");
            TextureManager.AddTexture("Desk", Constants.CollidableObjectDirectory + "Desk.png");
            TextureManager.AddTexture("Actionfigure", Constants.ItemsDirectory + "Actionfigure.png");
            TextureManager.AddTexture("Lampada", Constants.CollidableObjectDirectory + "Lampada.png");
            TextureManager.AddTexture("LettoRoom", Constants.CollidableObjectDirectory + "LettoRoom.png");
            TextureManager.AddTexture("SediaRoom1", Constants.CollidableObjectDirectory + "SediaRoom1.png");
            TextureManager.AddTexture("ArmadioRoom", Constants.CollidableObjectDirectory + "ArmadioRoom.png");
            TextureManager.AddTexture("ComodinoRoom", Constants.CollidableObjectDirectory + "ComodinoRoom.png");

            ////Kitchen
            TextureManager.AddTexture("Whiskey", Constants.ItemsDirectory + "Whiskey.png");
            TextureManager.AddTexture("Kitchen", Constants.BackgroundDirectory + "Kitchen.png");
            TextureManager.AddTexture("Frigorifero", Constants.ItemsDirectory + "Frigorifero.png");
            TextureManager.AddTexture("tavola_kitchen", Constants.CollidableObjectDirectory + "tavola_kitchen.png");
            TextureManager.AddTexture("banco_cucina_kitchen", Constants.CollidableObjectDirectory + "banco_cucina_kitchen.png");

            //////bathroom
            TextureManager.AddTexture("Retched", Constants.ItemsDirectory + "Retched.png");
            TextureManager.AddTexture("Bathroom", Constants.BackgroundDirectory + "Bathroom.png");
            TextureManager.AddTexture("CessoBidet", Constants.CollidableObjectDirectory + "CessoBidet.png");
            TextureManager.AddTexture("DoppioCesso", Constants.CollidableObjectDirectory + "DoppioCesso.png");
            TextureManager.AddTexture("LavandinoCesso", Constants.CollidableObjectDirectory + "LavandinoCesso.png");

            ////corridor
            TextureManager.AddTexture("Corridor", Constants.BackgroundDirectory + "Corridor.png");
            TextureManager.AddTexture("Pianta1", Constants.CollidableObjectDirectory + "Pianta1.png");

            //loungeArea
            TextureManager.AddTexture("PileMess", Constants.ItemsDirectory + "PileMess.png");
            TextureManager.AddTexture("LoungeArea", Constants.BackgroundDirectory + "LoungeArea.png");
            TextureManager.AddTexture("SediaSalone", Constants.CollidableObjectDirectory + "SediaSalone.png");
            TextureManager.AddTexture("Sedia2Salone1", Constants.CollidableObjectDirectory + "Sedia2Salone1.png");
            TextureManager.AddTexture("TvConCasseSalone", Constants.CollidableObjectDirectory + "TvConCasseSalone.png");
            TextureManager.AddTexture("SediaCadutaSalone", Constants.CollidableObjectDirectory + "SediaCadutaSalone.png");
            TextureManager.AddTexture("TavolaLungaSalone", Constants.CollidableObjectDirectory + "TavolaLungaSalone.png");

            //laboratory
            TextureManager.AddTexture("Guitar", Constants.ItemsDirectory + "Guitar.png");
            TextureManager.AddTexture("Laboratory", Constants.BackgroundDirectory + "Laboratory.png");
            TextureManager.AddTexture("Sketchbooketched", Constants.ItemsDirectory + "Sketchbooketched.png");
            TextureManager.AddTexture("batteria_laboratorio", Constants.CollidableObjectDirectory + "batteria_laboratorio.png");
            TextureManager.AddTexture("chitarra_laboratorio", Constants.CollidableObjectDirectory + "chitarra_laboratorio.png");
            TextureManager.AddTexture("TavoloDaLavoroLaboratory", Constants.CollidableObjectDirectory + "TavoloDaLavoroLaboratory.png");
            TextureManager.AddTexture("ScaffaleDaLavoroLaboratory", Constants.CollidableObjectDirectory + "ScaffaleDaLavoroLaboratory.png");

            //anteroomExit
            TextureManager.AddTexture("FamilyAlbum", Constants.ItemsDirectory + "FamilyAlbum.png");
            TextureManager.AddTexture("Pianta3", Constants.CollidableObjectDirectory + "Pianta3.png");
            TextureManager.AddTexture("AnteroomExit", Constants.BackgroundDirectory + "AnteroomExit.png");
            TextureManager.AddTexture("armadio_bedroom_parents", Constants.CollidableObjectDirectory + "armadio_bedroom_parents.png");


            //bedroomparents
            TextureManager.AddTexture("Pianta2", Constants.CollidableObjectDirectory + "Pianta2.png");
            TextureManager.AddTexture("BedroomParents", Constants.BackgroundDirectory + "BedroomParents.png");
            TextureManager.AddTexture("FramedFamilyPhoto", Constants.ItemsDirectory + "FramedFamilyPhoto.png");
            TextureManager.AddTexture("letto_bedroom_parents", Constants.CollidableObjectDirectory + "letto_bedroom_parents.png");
            TextureManager.AddTexture("mobile_bedroom_parents", Constants.CollidableObjectDirectory + "mobile_bedroom_parents.png");

            //centralCorridor
            TextureManager.AddTexture("CentralCorridor", Constants.BackgroundDirectory + "CentralCorridor.png");

            //InteractbleObject-items
            TextureManager.AddTexture("Empty", Constants.ItemsDirectory + "Empty.png");

            //PortraitSpriteSheet
            TextureManager.AddTexture("Dino", Constants.PortraitSpriteSheetDirectory + "Dino.png");
            TextureManager.AddTexture("Foto", Constants.PortraitSpriteSheetDirectory + "Foto.png");
            TextureManager.AddTexture("Alcol", Constants.PortraitSpriteSheetDirectory + "Alcol.png");
            TextureManager.AddTexture("Album", Constants.PortraitSpriteSheetDirectory + "album.png");
            TextureManager.AddTexture("Vomito", Constants.PortraitSpriteSheetDirectory + "Vomito.png");
            TextureManager.AddTexture("Chitarra", Constants.PortraitSpriteSheetDirectory + "Chitarra.png");
            TextureManager.AddTexture("Bordello", Constants.PortraitSpriteSheetDirectory + "Bordello.png");
            TextureManager.AddTexture("ComputerPortrait", Constants.PortraitSpriteSheetDirectory + "Computer.png");
            TextureManager.AddTexture("BloccoDisegni", Constants.PortraitSpriteSheetDirectory + "BloccoDisegni.png");

            //Dialogue
            TextureManager.AddTexture("sfondo", Constants.DialogueDirectory + "sfondo.png");
            TextureManager.AddTexture("vomito", Constants.DialogueDirectory + "vomito.png");
            TextureManager.AddTexture("whiskey", Constants.DialogueDirectory + "whiskey.png");
            TextureManager.AddTexture("bordello", Constants.DialogueDirectory + "bordello.png");
            TextureManager.AddTexture("chitarra", Constants.DialogueDirectory + "chitarra.png");
            TextureManager.AddTexture("computer", Constants.DialogueDirectory + "computer.png");
            TextureManager.AddTexture("fotoricordo", Constants.DialogueDirectory + "fotoricordo.png");
            TextureManager.AddTexture("albumdifoto", Constants.DialogueDirectory + "albumdifoto.png");
            TextureManager.AddTexture("actionfigure", Constants.DialogueDirectory + "actionfigure.png");
            TextureManager.AddTexture("bloccodisegno", Constants.DialogueDirectory + "bloccodisegno.png");

            //Menu
            TextureManager.AddTexture("Menu", Constants.SplashScreenDirectory + "BG.png");
            TextureManager.AddTexture("PlayButton", Constants.SplashScreenDirectory + "play.png");
            TextureManager.AddTexture("QuitButton", Constants.SplashScreenDirectory + "quit.png");
            TextureManager.AddTexture("BadEnd", Constants.SplashScreenDirectory + "the end.png");

            //Door
            TextureManager.AddTexture("EndDoor", Constants.ItemsDirectory + "EndDoor.png");
            TextureManager.AddTexture("BackDoor", Constants.ItemsDirectory + "BackDoor.png");
            TextureManager.AddTexture("FrontDoor", Constants.ItemsDirectory + "FrontDoor.png");
            TextureManager.AddTexture("LateralDoor", Constants.ItemsDirectory + "LateralDoor.png");


            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "cursore.png");
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "pg_walkstate.png");
        }
    }
}
