using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Trigger : MonoBehaviour
{

    public Animator animator;




    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            //Debug.Log  ("Player has entered");
            animator.SetBool("InTrigger", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("InTrigger", false);
    }
}
