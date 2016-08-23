using UnityEngine;
using uFrame.Attributes;
using TetrisDB;
using System;

[ActionLibrary, uFrameCategory("Tetris")]
public static class TetrisUtils {
    
	public static void Update(GroupComponent component, Action yes, Action no)
    {
        if(!GridUtil.gameIsPaused)
        {
            //Vector3 pos = component.transform.position;
            component.transform.position += new Vector3(0, -1, 0);

            if (isValidGridPos(component))
            {
                updateGrid(component);
            }
            else
            {
                component.transform.position += new Vector3(0, 1, 0);
                GridUtil.deleteFullRows();
                yes.Invoke();
                return;
            }

            no.Invoke();
        }
    }

    public static void TryMoveLeft(GroupComponent component)
    {
        if (!GridUtil.gameIsPaused)
        {
            component.transform.position += new Vector3(-1, 0, 0);

            // See if valid
            if (isValidGridPos(component))
                // It's valid. Update grid.
                updateGrid(component);
            else
                // It's not valid. revert.
                component.transform.position += new Vector3(1, 0, 0);
        }
    }

    public static void TryMoveRight(GroupComponent component)
    {
        if (!GridUtil.gameIsPaused)
        {
            component.transform.position += new Vector3(1, 0, 0);

            // See if valid
            if (isValidGridPos(component))
                // It's valid. Update grid.
                updateGrid(component);
            else
                // It's not valid. revert.
                component.transform.position += new Vector3(-1, 0, 0);
        }
    }

    public static void TryRotate(GroupComponent component)
    {
        if (!GridUtil.gameIsPaused)
        {
            component.transform.Rotate(0, 0, -90);

            // See if valid
            if (isValidGridPos(component))
                // It's valid. Update grid.
                updateGrid(component);
            else
                // It's not valid. revert.
                component.transform.Rotate(0, 0, 90);
        }
    }

    private static void updateGrid(GroupComponent component)
    {
        // Remove old children from grid
        for (int y = 0; y < GridUtil.h; ++y)
            for (int x = 0; x < GridUtil.w; ++x)
                if (GridUtil.grid[x, y] != null)
                    if (GridUtil.grid[x, y].parent == component.transform)
                        GridUtil.grid[x, y] = null;

        // Add new children to grid
        foreach (Transform child in component.transform)
        {
            Vector2 v = GridUtil.roundVec2(child.position);
            GridUtil.grid[(int)v.x, (int)v.y] = child;
        }
    }

    public static bool isValidGridPos(GroupComponent component)
    {
        foreach (Transform child in component.transform)
        {
            Vector2 v = GridUtil.roundVec2(child.position);

            // Not inside Border?
            if (!GridUtil.insideBorder(v))
                return false;

            // Block in grid cell (and not part of same group)?
            if (GridUtil.grid[(int)v.x, (int)v.y] != null &&
                GridUtil.grid[(int)v.x, (int)v.y].parent != component.transform)
                return false;
        }
        return true;
    }
}
