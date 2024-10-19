using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float horizontalInput ;
    const float movementSpeed = 15;
    const float maxXbound = 18;
    public projectile selectedProjectile;
    public projectile pizza;
    public KeyCode fireProjectileKey;
    // Update is called once per frame
    void Update()
    {       
        horizontalInput = Input.GetAxis("Horizontal");      
        transform.Translate(horizontalInput * Time.deltaTime * new Vector3(1, 0, 0) * movementSpeed);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x ,-maxXbound,maxXbound), transform.position.y, transform.position.z);

        // if player moves beyond x = 18 then put it back to x = 18 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedProjectile = pizza;


        }
        if (pizza != null)
        {
            if (Input.GetKeyDown(fireProjectileKey)||Input.GetMouseButtonDown(0)) 
            {
                projectile selectedInstanceProjectile = Instantiate(selectedProjectile,transform.position,pizza.transform.rotation);
            }
        }       
    }
}
