using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Orange_Lib
{
    //  Orange Library
    //
    //  This library is a set of functions which might make game development easier for

    public static float Vector2ToAngle(Vector2 vec)
    {
        //calculates the angle between a vector2 and the x-axis in degrees
        float angle =
            (
                Mathf.Atan(vec.y /vec.x) /
                (Mathf.PI * 2.0f) +
                Convert.ToInt32(vec.x < 0) * 0.5f
            ) * 360;

        return angle;
    }

    public static Vector2 AngleToVector2(float angle)
    {
        //calculates a unit-vector for which the angle in degrees between the x-axis and the vector is the input angle
        angle = angle * Mathf.Deg2Rad;
        Vector2 vec = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        return vec;
    }

    public static float ManhattanDistance(Vector2 pos1, Vector2 pos2)
    {
        return Mathf.Abs(pos1.x - pos2.x) + Mathf.Abs(pos1.y - pos2.y);
    }

    public static T GetRandomItemInArray<T>(T[] arr)
    {
        return arr[Mathf.FloorToInt(UnityEngine.Random.Range(0.0f, arr.Length))];
    }
}
