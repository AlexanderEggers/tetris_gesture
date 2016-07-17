using UnityEngine;
using uFrame.Attributes;
using TetrisDB;
using System;

[ActionLibrary, uFrameCategory("Tetris")]
public static class TetrisUtils {
    
	public static void Update(GroupComponent component, Action yes, Action no)
    {
        //Vector3 pos = component.transform.position;
        component.transform.position += new Vector3(0, -1, 0);

        if(isValidGridPos(component))
        {
            updateGrid(component);
        } else
        {
            component.transform.position += new Vector3(0, 1, 0);
            GridUtil.deleteFullRows();
            yes.Invoke();
            return;
        }

        no.Invoke();
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

    private static bool isValidGridPos(GroupComponent component)
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
