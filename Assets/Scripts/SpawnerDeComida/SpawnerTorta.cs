using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTorta : MonoBehaviour
{
    public GameObject comidaPrefab;
    public GameObject comida;
    public GameObject puntoDeAparicion;

    void Start()
    {
        comida = GameObject.FindGameObjectWithTag("Torta");

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
