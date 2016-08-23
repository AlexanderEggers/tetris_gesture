using UnityEngine;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Tetris_GUI")]
public static class GUIUtil {

    public static void OpenMenu()
    {
        GridUtil.gameIsPaused = true;
    }

    public static void CloseMenu()
    {
        GridUtil.gameIsPaused = false;
    }

    public static void ExitGame()
    {
        Time.timeScale = 0;
        //TODO: Change to exit game later if application is being deployed
    }
}
