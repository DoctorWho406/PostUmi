using OpenTK;
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
            TextureManager.AddTexture("Empty", Constants.InteractableObjectDirectory + "Empty.png");

            TextureManager.AddTexture("Actionfigure", Constants.ItemsDirectory + "Actionfigure.png");
            TextureManager.AddTexture("Computer", Constants.ItemsDirectory + "Computer.png");
            TextureManager.AddTexture("Desk", Constants.ItemsDirectory + "Desk.png");
            TextureManager.AddTexture("FamilyAlbum", Constants.ItemsDirectory + "FamilyAlbum.png");
            TextureManager.AddTexture("FramedFamilyPhoto", Constants.ItemsDirectory + "FramedFamilyPhoto.png");
            TextureManager.AddTexture("Guitar", Constants.ItemsDirectory + "Guitar.png");
            TextureManager.AddTexture("PileMess", Constants.ItemsDirectory + "PileMess.png");
            TextureManager.AddTexture("Retched", Constants.ItemsDirectory + "Retched.png");
            TextureManager.AddTexture("Sketchbook", Constants.ItemsDirectory + "Sketchbooketched.png");
            TextureManager.AddTexture("Wisky", Constants.ItemsDirectory + "Wisky.png");
        }

        #region Rooms        
        private static void RoomLoad() {
            //new Background("Room", Scene.Room) { Position = Game.WindowCenter};
            new Door("FrontDoor", Scene.Room, Scene.CentralCorridor) { Position = Game.WindowCenter }.Scale(0.3f);
        }

        private static void CentralCorridorLoad() {
            //new Background("CentralCorridor", Scene.CentralCorridor) { Position = Game.WindowCenter };
            new Door("FrontDoor", Scene.CentralCorridor, Scene.LoungeArea) { Position = Game.WindowCenter +Vector2.UnitX*-300};
            new Door("FrontDoor", Scene.CentralCorridor, Scene.AnteroomExit) { Position = Game.WindowCenter +Vector2.UnitY * -300 };
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
        #endregion
    }
}
