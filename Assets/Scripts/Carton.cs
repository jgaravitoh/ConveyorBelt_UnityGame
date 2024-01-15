using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carton : MonoBehaviour
{
    public GameObject carton;
    public GameObject cartonHolder;
    public float velocity = 0;
    public bool crearCartones = true;
    float tiempoInstancia;
    void Start()
    {
        transform.position = new Vector3(-15,0.9f,0);
        cartonHolder = GameObject.Find("CartonesHolder");
        this.transform.parent = cartonHolder.transform;
        tiempoInstancia = Time.time;
    }

    void FixedUpdate()
    {        
        if (Time.time - tiempoInstancia >= 2.10 / velocity && crearCartones)
        {
            Instantiate(carton);
            crearCartones = false;
        }
        

        if (velocity > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime *velocity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Banda")
        {
            velocity = 8f;
        }
        if (collision.gameObject.tag == "RecogeCajas")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "FrenaCajas")
        {
            velocity = 0;
        }
    }
}
