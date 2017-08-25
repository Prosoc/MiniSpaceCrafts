using UnityEngine;
using System.Collections;

public static class EventHandler{


    public delegate void LoopFunction();
    public static event LoopFunction OnLoopFunction;
    
    public static void OnLoopFunctions()
    {
        OnLoopFunction();
    }
}
