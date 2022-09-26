using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerClients : MonoBehaviour
{
    public GameObject clientPrefab;
    public GameObject client;
    public GameObject puntoDeAparicion;


    void Update()
    {
        client = GameObject.FindGameObjectWithTag("BCP boi");

        if (client == null)
        {
            Invoke("Client", 0f);
        }
    }

    void Client()
    {
        Instantiate(clientPrefab, puntoDeAparicion.transform.position, Quaternion.identity);
    }
}
