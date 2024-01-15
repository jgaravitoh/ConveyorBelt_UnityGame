using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFromDistributionExtended : MonoBehaviour
{
    public static float RandomExponentialDistributionMean(float mean)
    {
        float u = (float)new System.Random().NextDouble(); // Uniform random number between 0 and 1
        return -mean * Mathf.Log(1 - u); // Exponential random number formula
    }
}
