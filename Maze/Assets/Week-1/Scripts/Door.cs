using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool requiresKey = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (requiresKey && other.GetComponent<PlayerInventory>().HasKey())
            { 
                transform.Rotate(0, 90, 0);
            }
        }
    }
}