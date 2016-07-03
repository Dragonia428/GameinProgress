using UnityEngine;
using System.Collections;
using System;

public class Level {
    static int level = 1;
    // Use this for initialization
    public static void LevelUp()
    {
        level++;
    }
    private bool ifUnderOne(int level)
    {
        if (level < 1) return true;
        else return false;
    }
}
