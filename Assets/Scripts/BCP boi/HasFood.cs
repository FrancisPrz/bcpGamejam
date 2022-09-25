using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasFood : MonoBehaviour
{
    public GameObject food;
    public BcpMenMovement1 bcpMen;

    public void EatingFood()
    {
        Debug.Log("BCPboi comiendo");
        bcpMen.eating = true;
        Destroy(food, 4f);
        Invoke(nameof(GoOutside), 4f);
    }

    public void GoOutside()
    {
        bcpMen.eating = false;
    }
}
