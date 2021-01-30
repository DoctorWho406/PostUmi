namespace GGJam_2021 {
    static class AssetsManager {
        public static void Init() {
            AssetLoaded();
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
            TextureManager.AddTexture("Player", Constants.InteractableObjectDirectory + "PlayerProva.png");
            TextureManager.AddTexture("FrontDoor", Constants.InteractableObjectDirectory + "FrontDoor.png");
            TextureManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursore di prova.jpg");
          
            TextureManager.AddTexture("Actionfigure", Constants.TextureDirectory + "Actionfigure.png");
            TextureManager.AddTexture("Computer", Constants.TextureDirectory + "Computer.png");
            TextureManager.AddTexture("Desk", Constants.TextureDirectory + "Desk.png");
            TextureManager.AddTexture("FamilyAlbum", Constants.TextureDirectory + "FamilyAlbum.png");
            TextureManager.AddTexture("FramedFamilyPhoto", Constants.TextureDirectory + "FramedFamilyPhoto.png");
            TextureManager.AddTexture("Guitar", Constants.TextureDirectory + "Guitar.png");
            TextureManager.AddTexture("PileMess", Constants.TextureDirectory + "PileMess.png");
            TextureManager.AddTexture("Retched", Constants.TextureDirectory + "Retched.png");
            TextureManager.AddTexture("Sketchbook", Constants.TextureDirectory + "Sketchbooketched.png");
            TextureManager.AddTexture("Wisky", Constants.TextureDirectory + "Wisky.png");
        }
        #region Rooms        
        private static void RoomLoad() {
            new Background("Room", Scene.Room) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Room, Scene.CentralCorridor) { Position = Game.WindowCenter };
        }
        private static void CentralCorridorLoad() {
            new Background("CentralCorridor", Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.AnteroomExit) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.Corridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.Room) { Position = Game.WindowCenter };
        }
        private static void AnteroomExit() {
            new Background("AnteroomExit", Scene.AnteroomExit) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.AnteroomExit, Scene.CentralCorridor) { Position = Game.WindowCenter };
            //new Door("FrontDoor", Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter };
        }
        private static void LondeAreaLoad() {
            new Background("LoungeArea", Scene.LoungeArea) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.Bathroom) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.LoungeArea, Scene.Kitchen) { Position = Game.WindowCenter };
        }
        private static void KitchenLoad() {
            new Background("Kitchen", Scene.Kitchen) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Kitchen, Scene.LoungeArea) { Position = Game.WindowCenter };
        }
        private static void BathroomLoad() {
            new Background("Bathroom", Scene.Bathroom) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Bathroom, Scene.LoungeArea) { Position = Game.WindowCenter };
        }
        private static void CorridorLoad() {
            new Background("Corridor", Scene.Corridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.Laboratory) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Corridor, Scene.BedroomParents) { Position = Game.WindowCenter };
        }
        private static void LaboratoryLoad() {
            new Background("Laboratory", Scene.Laboratory) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.Laboratory, Scene.Corridor) { Position = Game.WindowCenter };
        }
        private static void BedroomParentsLoad() {
            new Background("BedroomParents", Scene.BedroomParents) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.BedroomParents, Scene.Corridor) { Position = Game.WindowCenter };
        }
        #endregion
    }
}
