using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator Anim;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Anim.SetBool("WalkRight", true);
        }
        else
        {
            Anim.SetBool("WalkRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Anim.SetBool("WalkLeft", true);
        }
        else
        {
            Anim.SetBool("WalkLeft", false);
        }
    }
}
