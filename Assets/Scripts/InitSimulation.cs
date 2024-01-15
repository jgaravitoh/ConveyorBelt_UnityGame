using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSimulation : MonoBehaviour
{
    [SerializeField]
    public GameObject carton;
    public int cartonesGenerados;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(carton);
        Time.timeScale = 1;
    }
}
