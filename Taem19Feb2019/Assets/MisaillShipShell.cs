using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisaillShipShell : MonoBehaviour
{
    public GameObject misaillShellPrefad;
    public float shotSpeed;
    public AudioClip shotSound;
    public float shotIntarval;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shotIntarval += 1;
        if (shotIntarval % 60 == 0)
        {
            GameObject misaillShell = Instantiate(misaillShellPrefad, transform.position, Quaternion.identity);

            Rigidbody misaillShellRb = misaillShell.GetComponent<Rigidbody>();

            misaillShellRb.AddForce(transform.forward * shotSpeed);

            

            Destroy(misaillShell, 6.0f);
        }
    }
}
