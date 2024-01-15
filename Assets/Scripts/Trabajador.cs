using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trabajador : MonoBehaviour
{
    public int contadorCartonesTrabajados;
    public bool estaOcupado;

    Color libreColor = new Color(0.5f, 1f, 0f, 0.31f);
    Color ocupadoColor = new Color(1f, 0f, 0f, 0.31f);
    Material colorComponente;

    // Start is called before the first frame update
    void Start()
    {
        contadorCartonesTrabajados = 0;
        estaOcupado = false;
        colorComponente = this.GetComponent<Renderer>().material;
        colorComponente.SetColor("_Color", libreColor);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Carton" && estaOcupado ==  false)
        {
            print("se ocupa");
            estaOcupado = true;
            contadorCartonesTrabajados++;
            Destroy(other.gameObject);
            colorComponente.SetColor("_Color",ocupadoColor);
            StartCoroutine(DesocuparCoroutine());

        }
    }

    IEnumerator DesocuparCoroutine()
    {
        yield return new WaitForSeconds(RandomFromDistribution.RandomNormalDistribution(15, 3));
        estaOcupado = false;
        colorComponente.SetColor("_Color", libreColor);
        print("se desocupa");
    }

}
