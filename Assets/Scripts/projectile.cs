using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float projectileSpeed;
    // Update is called once per frame

    private void Start()
    {
        Destroy(gameObject,5);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        
    }
}
