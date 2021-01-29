namespace GGJam_2021 {
    static class AssetsManager {
        public static void Init() {
            AssetLoaded();
        }

        private static void AssetLoaded() {
            //BackgroundDirectoey
            TextureManager.AddTexture("Room", Constants.BackgroundDirectory + "Room.png");
            TextureManager.AddTexture("AnteroomExit", Constants.BackgroundDirectory + "AnteroomExit.png");
            TextureManager.AddTexture("CentralCorridor", Constants.BackgroundDirectory + "CentralCorridor.png");
            TextureManager.AddTexture("LoungeArea", Constants.BackgroundDirectory + "LoungeArea.png");
            TextureManager.AddTexture("Kitchen", Constants.BackgroundDirectory + "Kitchen.png");
            TextureManager.AddTexture("Bathroom", Constants.BackgroundDirectory + "Bathroom.png");
            TextureManager.AddTexture("Corridor", Constants.BackgroundDirectory + "Corridor.png");
            TextureManager.AddTexture("Laboratory", Constants.BackgroundDirectory + "Laboratory.png");
            TextureManager.AddTexture("BedroomParents", Constants.BackgroundDirectory + "BedroomParents.png");

            //interactbleObject
            TextureManager.AddTexture("Player", Constants.TextureDirectory + "PlayerProva.png");
            TextureManager.AddTexture("FrontDoor", Constants.TextureDirectory + "FrontDoor.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
        }

        private static void RoomLoad() {
            new Background("Room", Scene.StanzaPlayer) { Position = Game.WindowCenter };
            //new Door("FrontDoor", Scene.Stanza, Scene.Corridoio) { Position = Game.WindowCenter };
        }

        private static void LondeAreaLoad() {
            //new Background("salone", Scene.Corridoio) { Position = Game.WindowCenter };
            //new Door("FrontDoor", Scene.Stanza, Scene.Corridoio) { Position = Game.WindowCenter };
        }


    }
}
