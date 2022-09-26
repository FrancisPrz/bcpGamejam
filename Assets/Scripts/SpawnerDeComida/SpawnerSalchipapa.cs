using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSalchipapa : MonoBehaviour
{
    public GameObject comidaPrefab;
    public GameObject comida;
    public GameObject puntoDeAparicion;

    void Update()
    {
        comida = GameObject.FindGameObjectWithTag("Salchipapa");

        if (comida == null)
        {
            Invoke(nameof(Food), 0f);
        }
    }

    void Food()
    {
        Instantiate(comidaPrefab, puntoDeAparicion.transform.position, Quaternion.identity);
    }
}
