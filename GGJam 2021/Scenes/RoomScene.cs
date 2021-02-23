using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace GGJam_2021 {
    class RoomScene : Scene {
        protected Player player;
        public RoomScene() : base(){
        }

        public override void Start() {
            base.Start();
            new Background("Room", new Vector2(-119, -115), new Vector2(1173, 858));
            player = new Player();
            player.Scale(0.35f);
        }

        protected override void LoadAssets() {
            base.LoadAssets();
            GfxManager.AddTexture("Room", Constants.BackgroundDirectory + "Room.png");
            GfxManager.AddTexture("Computer", Constants.ItemsDirectory + "Computer.png");
            GfxManager.AddTexture("Desk", Constants.CollidableObjectDirectory + "Desk.png");
            GfxManager.AddTexture("Actionfigure", Constants.ItemsDirectory + "Actionfigure.png");
            GfxManager.AddTexture("Lampada", Constants.CollidableObjectDirectory + "Lampada.png");
            GfxManager.AddTexture("LettoRoom", Constants.CollidableObjectDirectory + "LettoRoom.png");
            GfxManager.AddTexture("SediaRoom1", Constants.CollidableObjectDirectory + "SediaRoom1.png");
            GfxManager.AddTexture("ArmadioRoom", Constants.CollidableObjectDirectory + "ArmadioRoom.png");
            GfxManager.AddTexture("ComodinoRoom", Constants.CollidableObjectDirectory + "ComodinoRoom.png");

            GfxManager.AddTexture("Hunger", Constants.TextureDirectory + "barrafame.png");
            GfxManager.AddTexture("Paranoia", Constants.TextureDirectory + "barraparanoia.png");
            GfxManager.AddTexture("Player", Constants.TextureDirectory + "pg_walkstate.png");
        }

        public override void Input() {
            player.Input();
        }
    }
}
