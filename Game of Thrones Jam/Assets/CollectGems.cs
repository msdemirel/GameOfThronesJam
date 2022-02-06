using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGems : MonoBehaviour
{
    public GameObject collectEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        this.gameObject.SetActive(false);

        Instantiate(collectEffect, transform.position, Quaternion.identity);

    }

    
}
