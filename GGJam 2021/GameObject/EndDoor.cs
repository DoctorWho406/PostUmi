using OpenTK;

namespace GGJam_2021 {
    class EndDoor : Door {
        public EndDoor() : base("EndDoor", Vector2.Zero, false, 67, 0, Constants.FPSDoorAnimation) {
        }
		public override void SetGlitch(bool value) {
		}
	}
}
