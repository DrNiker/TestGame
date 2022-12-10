using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    Player pl;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        BoxCollider bc = GetComponent<BoxCollider>();
        bc.enabled = false;
        pl = other.GetComponent<Player>();
        pl.EndGame();
    }
}
