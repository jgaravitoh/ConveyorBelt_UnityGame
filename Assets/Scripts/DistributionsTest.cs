using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DistributionsTest : MonoBehaviour
{
    public float[] randomNumbersArray = new float[1000];

    public RandomData data;
    public const string pathData = "Data/test";
    public const string nameFileData = "ExponentialDistributionData";

    void Start()
    {
        var dataFound = SaveLoadSystemData.LoadData<RandomData>(pathData, nameFileData);
        if (dataFound!=null)
        {
            data = dataFound;
        }
        else
        {
            data = new RandomData();
            SaveData();
        }
        TestExponential();
    }

   public void TestNormal()
    {
        for (int i = 0; i < 1000; i++)
        {
            randomNumbersArray[i] = RandomFromDistribution.RandomNormalDistribution(15, 3);
            // RandomFromDistribution.RandomNormalDistribution(mean, std dev);
        }
        data.randomArray = randomNumbersArray;
        SaveData();
    }
    public void TestExponential()
    {
        for (int i = 0; i < 1000; i++)
        {
            randomNumbersArray[i] = RandomFromDistributionExtended.RandomExponentialDistributionMean(2.40f);
            // RandomFromDistributionExtended.RandomExponentialDistributionMean(mean);
        }
        data.randomArray = randomNumbersArray;
        SaveData();
        
    }
    private void SaveData()
    {
        SaveLoadSystemData.SaveData(data, pathData, nameFileData);
    }
}
