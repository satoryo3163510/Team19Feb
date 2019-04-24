using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropEB : MonoBehaviour
{
    private float dropTimer;
    public GameObject enemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dropTimer+=1.0f*Time.deltaTime;
        if (dropTimer>5.0f)
        {
            GameObject Ebullets = Instantiate(enemyBullet, transform.position, Quaternion.identity);
            Destroy(Ebullets, 3f);
            dropTimer = 0;
        }
        
    }
}
