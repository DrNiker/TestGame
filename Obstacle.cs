using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float lifetime = 10f;
    void Update()
    {
        lifetime -= Time.deltaTime;
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        if (lifetime<0)
        {
            Destroy(this);
        }
    }
}
