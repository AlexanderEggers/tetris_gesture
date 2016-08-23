using UnityEngine;
using uFrame.Attributes;
using TetrisDB;
using System;

[ActionLibrary, uFrameCategory("Tetris_GUI")]
public static class GUIUtil {

    public static void ExitGame()
    {
        Time.timeScale = 0;
    }

    public static void ChangeHandVisibleGUI(bool visible)
    {

    }
}
