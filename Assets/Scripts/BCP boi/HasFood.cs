using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasFood : MonoBehaviour
{
    public GameObject food;

    public void EatingFood()
    {
        Debug.Log("BCPboi comiendo");
        Destroy(food, 4f);
    }
}
