using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGems : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        this.gameObject.SetActive(false);


    }
}
