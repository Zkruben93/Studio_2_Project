using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log  ("Player has entered");
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
