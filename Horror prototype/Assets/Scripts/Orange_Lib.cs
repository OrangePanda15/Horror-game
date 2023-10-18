using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Orange_Lib
{
    //  Orange Library
    //
    //  This library is a set of functions which might make game development easier for Orange Panda

    /// <summary>
    /// Calculates the angle between a vector2 and the x-axis in degrees anti-clockwise from the x-axis
    /// </summary>
    /// <param name="vec"></param>
    /// <returns></returns>
    public static float Vector2ToAngle(Vector2 vec)
    {
        float angle =
            (
                Mathf.Atan(vec.y /vec.x) /
                (Mathf.PI * 2.0f) +
                Convert.ToInt32(vec.x < 0) * 0.5f
            ) * 360;

        return angle;
    }

    /// <summary>
    /// Calculates a unit-vector angle degrees anti-clockwise from the x-axis
    /// </summary>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static Vector2 AngleToVector2(float angle)
    {
        angle = angle * Mathf.Deg2Rad;
        Vector2 vec = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        return vec;
    }

    /// <summary>
    /// Calculates the distance between two points assuming one can only move along either the x or y axis at a time
    /// </summary>
    /// <param name="pos1"></param>
    /// <param name="pos2"></param>
    /// <returns></returns>
    public static float ManhattanDistance(Vector2 pos1, Vector2 pos2)
    {
        return Mathf.Abs(pos1.x - pos2.x) + Mathf.Abs(pos1.y - pos2.y);
    }

    /// <summary>
    /// Returns a random item from an array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static T GetRandomItemInArray<T>(T[] arr)
    {
        return arr[Mathf.FloorToInt(UnityEngine.Random.Range(0.0f, arr.Length))];
    }

    /// <summary>
    /// <br>returns a string containing items from an array</br>
    /// <br>uses array type's default string conversion</br>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static string ArrayToString<T>(T[] arr)
    {
        string output = "";
        foreach (T item in arr)
        {
            output += ", " + item.ToString();
        }

        return output;
    }
}
