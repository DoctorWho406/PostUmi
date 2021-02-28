using System.Collections.Generic;

namespace GGJam_2021.Engine.Scenes {
	abstract class CorridorScene : PlayScene {
		protected Dictionary<ChangeSceneObject, Scene> link;
		protected CorridorScene() : base() {
		}

		public override void Input() {
			base.Input();
			foreach (KeyValuePair<ChangeSceneObject, Scene> item in link) {
				if(item.Key.ReadyForChange) {
					item.Key.ReadyForChange = false;
					NextScene = item.Value;
					IsPlaying = false;
					break;
				}
			}
		}

	}
}
