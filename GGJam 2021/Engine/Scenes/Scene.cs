namespace GGJam_2021 {
    abstract class Scene {
        public bool IsPlaying {
            get; protected set;
        }
        public Scene NextScene;

        public Scene() {
        }

        public virtual void Start() {
            IsPlaying = true;
            LoadAssets();
            new Cursor().Scale(0.3f);
        }

        protected virtual void LoadAssets() {
            GfxManager.AddTexture("Cursor", Constants.TextureDirectory + "Cursor.png");
        }

        public virtual Scene OnExit() {
            GfxManager.ClearAll();
            UpdateManager.ClearAll();
            PhysicsManager.ClearAll();
            DrawManager.ClearAll();
            IsPlaying = false;
            return NextScene;
        }

        public virtual void Update() {
            UpdateManager.Update();
        }

        public virtual void Input() {

        }

        public virtual void Draw() {
            DrawManager.Draw();
        }
    }
}
