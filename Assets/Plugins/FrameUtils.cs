using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using Leap;


[ActionLibrary, uFrameCategory("Frame")]
public static class FrameUtils {

    private static Controller controller = new Controller();


    public static Frame getFrame()
    {
        return controller.Frame();
    }

    public static void getHandsFromFrame(Frame frame, out Hand first, out Hand second)
    {
       
        if(frame==null ||frame.Hands.Count==0)
        {
            first = null;
            second = null;
        } else if(frame.Hands.Count==1)
        {
            first = frame.Hands[0];
            second = null;
        } else
        {
            first = frame.Hands[0];
            second = frame.Hands[1];
        }
    }

    public static void getLeftHandFromFrame(Frame frame, out Hand left)
    {
        left = null;
        if (frame != null)
        {
            for (int i = 0; i < frame.Hands.Count; i++)
            {
                if (frame.Hands[i].IsLeft)
                {
                    left = frame.Hands[i];
                    return;
                }
            }
        }

    }

    public static void getRightHandFromFrame(Frame frame, out Hand right)
    {
        right = null;
        if (frame != null)
        {
            for (int i = 0; i < frame.Hands.Count;i++)
            {
                if (frame.Hands[i].IsRight)
                {
                    right = frame.Hands[i];
                    return;
                }
            }
        }

    }
}
