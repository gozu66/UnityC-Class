using UnityEngine;
using System.Collections;

public static class StaticClass
{
    public static int staicClassInt = 1;
    public static string staticClassString = "Static";

    public static void DisplayName(string name)
    {
        Debug.Log(staticClassString);
    }
}
