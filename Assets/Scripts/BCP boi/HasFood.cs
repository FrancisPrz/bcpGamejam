using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasFood : MonoBehaviour
{
    public GameObject food;
    public BcpMenMovement1 bcpMen;

    public InteractionPromptUI interactionPrompt;

    private void Start()
    {
        bcpMen = GetComponent<BcpMenMovement1>();
    }

    public void EatingFood()
    {
        Debug.Log("BCPboi comiendo");
        bcpMen.doingSth = true;
        Destroy(food, 2.5f);
        Invoke(nameof(GoOutside), 2.6f);
    }

    public void GoOutside()
    {
        bcpMen.doingSth = false;
        interactionPrompt.SetUp("");
    }
}
