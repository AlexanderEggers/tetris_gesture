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
        Application.Quit();
    }

    public static void LostGame()
    {
        Time.timeScale = 0;
    }
}
