using OpenTK;
namespace GGJam_2021 {
    static class TextureInitManager {
        public static void Start() {
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
    }
}
