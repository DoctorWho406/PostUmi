namespace GGJam_2021 {
    static class TextureInitManager {
        public static void Start() {
            //Background
            ////Kitchen
            GfxManager.AddTexture("Whiskey", Constants.ItemsDirectory + "Whiskey.png");
            GfxManager.AddTexture("Kitchen", Constants.BackgroundDirectory + "Kitchen.png");
            GfxManager.AddTexture("Frigorifero", Constants.ItemsDirectory + "Frigorifero.png");
            GfxManager.AddTexture("tavola_kitchen", Constants.CollidableObjectDirectory + "tavola_kitchen.png");
            GfxManager.AddTexture("banco_cucina_kitchen", Constants.CollidableObjectDirectory + "banco_cucina_kitchen.png");

            //////bathroom
            GfxManager.AddTexture("Retched", Constants.ItemsDirectory + "Retched.png");
            GfxManager.AddTexture("Bathroom", Constants.BackgroundDirectory + "Bathroom.png");
            GfxManager.AddTexture("CessoBidet", Constants.CollidableObjectDirectory + "CessoBidet.png");
            GfxManager.AddTexture("DoppioCesso", Constants.CollidableObjectDirectory + "DoppioCesso.png");
            GfxManager.AddTexture("LavandinoCesso", Constants.CollidableObjectDirectory + "LavandinoCesso.png");

            ////corridor
            GfxManager.AddTexture("Corridor", Constants.BackgroundDirectory + "Corridor.png");
            GfxManager.AddTexture("Pianta1", Constants.CollidableObjectDirectory + "Pianta1.png");

            //loungeArea
            GfxManager.AddTexture("PileMess", Constants.ItemsDirectory + "PileMess.png");
            GfxManager.AddTexture("LoungeArea", Constants.BackgroundDirectory + "LoungeArea.png");
            GfxManager.AddTexture("SediaSalone", Constants.CollidableObjectDirectory + "SediaSalone.png");
            GfxManager.AddTexture("Sedia2Salone1", Constants.CollidableObjectDirectory + "Sedia2Salone1.png");
            GfxManager.AddTexture("TvConCasseSalone", Constants.CollidableObjectDirectory + "TvConCasseSalone.png");
            GfxManager.AddTexture("SediaCadutaSalone", Constants.CollidableObjectDirectory + "SediaCadutaSalone.png");
            GfxManager.AddTexture("TavolaLungaSalone", Constants.CollidableObjectDirectory + "TavolaLungaSalone.png");

            //laboratory
            GfxManager.AddTexture("Guitar", Constants.ItemsDirectory + "Guitar.png");
            GfxManager.AddTexture("Laboratory", Constants.BackgroundDirectory + "Laboratory.png");
            GfxManager.AddTexture("Sketchbooketched", Constants.ItemsDirectory + "Sketchbooketched.png");
            GfxManager.AddTexture("batteria_laboratorio", Constants.CollidableObjectDirectory + "batteria_laboratorio.png");
            GfxManager.AddTexture("chitarra_laboratorio", Constants.CollidableObjectDirectory + "chitarra_laboratorio.png");
            GfxManager.AddTexture("TavoloDaLavoroLaboratory", Constants.CollidableObjectDirectory + "TavoloDaLavoroLaboratory.png");
            GfxManager.AddTexture("ScaffaleDaLavoroLaboratory", Constants.CollidableObjectDirectory + "ScaffaleDaLavoroLaboratory.png");

            //anteroomExit
            GfxManager.AddTexture("FamilyAlbum", Constants.ItemsDirectory + "FamilyAlbum.png");
            GfxManager.AddTexture("Pianta3", Constants.CollidableObjectDirectory + "Pianta3.png");
            GfxManager.AddTexture("AnteroomExit", Constants.BackgroundDirectory + "AnteroomExit.png");
            GfxManager.AddTexture("armadio_bedroom_parents", Constants.CollidableObjectDirectory + "armadio_bedroom_parents.png");


            //bedroomparents
            GfxManager.AddTexture("Pianta2", Constants.CollidableObjectDirectory + "Pianta2.png");
            GfxManager.AddTexture("BedroomParents", Constants.BackgroundDirectory + "BedroomParents.png");
            GfxManager.AddTexture("FramedFamilyPhoto", Constants.ItemsDirectory + "FramedFamilyPhoto.png");
            GfxManager.AddTexture("letto_bedroom_parents", Constants.CollidableObjectDirectory + "letto_bedroom_parents.png");
            GfxManager.AddTexture("mobile_bedroom_parents", Constants.CollidableObjectDirectory + "mobile_bedroom_parents.png");

            //centralCorridor
            GfxManager.AddTexture("CentralCorridor", Constants.BackgroundDirectory + "CentralCorridor.png");

            //InteractbleObject-items
            GfxManager.AddTexture("Empty", Constants.ItemsDirectory + "Empty.png");

            //PortraitSpriteSheet
            GfxManager.AddTexture("Dino", Constants.PortraitSpriteSheetDirectory + "Dino.png");
            GfxManager.AddTexture("Foto", Constants.PortraitSpriteSheetDirectory + "Foto.png");
            GfxManager.AddTexture("Alcol", Constants.PortraitSpriteSheetDirectory + "Alcol.png");
            GfxManager.AddTexture("Album", Constants.PortraitSpriteSheetDirectory + "album.png");
            GfxManager.AddTexture("Vomito", Constants.PortraitSpriteSheetDirectory + "Vomito.png");
            GfxManager.AddTexture("Chitarra", Constants.PortraitSpriteSheetDirectory + "Chitarra.png");
            GfxManager.AddTexture("Bordello", Constants.PortraitSpriteSheetDirectory + "Bordello.png");
            GfxManager.AddTexture("ComputerPortrait", Constants.PortraitSpriteSheetDirectory + "Computer.png");
            GfxManager.AddTexture("BloccoDisegni", Constants.PortraitSpriteSheetDirectory + "BloccoDisegni.png");

            //Dialogue
            GfxManager.AddTexture("sfondo", Constants.DialogueDirectory + "sfondo.png");
            GfxManager.AddTexture("vomito", Constants.DialogueDirectory + "vomito.png");
            GfxManager.AddTexture("whiskey", Constants.DialogueDirectory + "whiskey.png");
            GfxManager.AddTexture("bordello", Constants.DialogueDirectory + "bordello.png");
            GfxManager.AddTexture("chitarra", Constants.DialogueDirectory + "chitarra.png");
            GfxManager.AddTexture("computer", Constants.DialogueDirectory + "computer.png");
            GfxManager.AddTexture("fotoricordo", Constants.DialogueDirectory + "fotoricordo.png");
            GfxManager.AddTexture("albumdifoto", Constants.DialogueDirectory + "albumdifoto.png");
            GfxManager.AddTexture("actionfigure", Constants.DialogueDirectory + "actionfigure.png");
            GfxManager.AddTexture("bloccodisegno", Constants.DialogueDirectory + "bloccodisegno.png");

            GfxManager.AddTexture("DialogoEmpty", Constants.BackgroundDirectory + "DialogoEmpty.png");

            GfxManager.AddTexture("Start_1", Constants.DialogueDirectory + "Start_1.jpg");
            GfxManager.AddTexture("Start_2", Constants.DialogueDirectory + "Start_2.jpg");
            GfxManager.AddTexture("Start_3", Constants.DialogueDirectory + "Start_3.jpg");

            //Menu
            GfxManager.AddTexture("Menu", Constants.SplashScreenDirectory + "BG.png");
            GfxManager.AddTexture("PlayButton", Constants.SplashScreenDirectory + "play.png");
            GfxManager.AddTexture("QuitButton", Constants.SplashScreenDirectory + "quit.png");
            GfxManager.AddTexture("BadEnd", Constants.SplashScreenDirectory + "the end.png");
            GfxManager.AddTexture("GoodEnd", Constants.SplashScreenDirectory + "good end.jpg");


            //Door
            GfxManager.AddTexture("EndDoor", Constants.ItemsDirectory + "EndDoor.png");
            GfxManager.AddTexture("BackDoor", Constants.ItemsDirectory + "BackDoor.png");
            GfxManager.AddTexture("FrontDoor", Constants.ItemsDirectory + "FrontDoor.png");
            GfxManager.AddTexture("LateralDoor", Constants.ItemsDirectory + "LateralDoor.png");

            //UI
            GfxManager.AddTexture("Player", Constants.TextureDirectory + "pg_walkstate.png");

            GfxManager.AddTexture("BackPlayer", Constants.TextureDirectory + "BackPlayer.png");
        }
    }
}
