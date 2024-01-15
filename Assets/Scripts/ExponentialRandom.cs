using UnityEngine;
public class ExponentialRandom : MonoBehaviour
{
    

    

    // Generate a random number following an exponential distribution
    float GenerateRandomExponential(float mean)
    {
        float u = (float) new System.Random().NextDouble(); // Uniform random number between 0 and 1
        return -mean * Mathf.Log(1 - u); // Exponential random number formula
    }
    void Start()
    {
        
        float randomValue = GenerateRandomExponential(15);
        Debug.Log("Random Exponential Value: " + randomValue);
    }

}
