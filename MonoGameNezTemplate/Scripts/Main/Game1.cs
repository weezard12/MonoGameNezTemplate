using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.ImGuiTools;

namespace MonoGameNezTemplate.Scripts
{
    public class Game1 : Core
    {
        public Game1()
        {
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            PauseOnFocusLost = false;
            Core.ExitOnEscapeKeypress = false;

            //no fps limit
            IsFixedTimeStep = false;
            Screen.SynchronizeWithVerticalRetrace = false;
            Screen.ApplyChanges();

            base.Initialize();

            Core.DebugRenderEnabled = true;

            var imGuiManager = new ImGuiManager();
            Core.RegisterGlobalManager(imGuiManager);

            // toggle ImGui rendering on/off. It starts out enabled.
            imGuiManager.SetEnabled(true);
        }

    }
}
