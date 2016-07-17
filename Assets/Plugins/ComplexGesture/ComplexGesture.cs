using UnityEngine;
using System.Collections.Generic;
using Leap;

public class ComplexGesture {

    private List<ComplexCondition> conditions = new List<ComplexCondition>();
        
    public void addCondition(ComplexCondition condition)
    {
        conditions.Add(condition);
    }

    public bool isSatisfied(Hand hand)
    {
        
        //No for each loop bc they have a memory leak
        for(int i=0; i<conditions.Count;i++)
        {
            if (!conditions[i].isSatisfied(hand)) return false;
        }
        return true;
    }
}
