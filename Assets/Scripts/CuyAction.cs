using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyAction : MonoBehaviour
{
    public Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            anim.SetTrigger("Stretch");
        }
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            anim.SetTrigger("Dance");
        }
    }
}
