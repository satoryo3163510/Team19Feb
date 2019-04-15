using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisaillShipattack : MonoBehaviour
{
    //発射間隔調整
    public GameObject shellPrefad;
    public float shotSpeed;
    public AudioClip shotSound;

    private float timeVeweenShot = 0.35f;
    private float timer;
    //ホーミング
    public Transform target;
    public Vector3 velcoity;
    public Vector3 position;
    public float period;

    public float maxAcceleration = 100;

    
    public float randomPower;
    public float randomPeriod;

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //ホーミングミサイルプログラム
        if (target == null)
            return;

        var acceleration = Vector3.zero;
        var diff = target.position - position;

        acceleration += (diff - velcoity * period) * 2f / (period * period);

        if (0 < randomPeriod)
        {
            var xr = Random.Range(-randomPower, randomPower);
             
            var yr = Random.Range(-randomPower, randomPower);

            var zr = Random.Range(-randomPower, randomPower);
            acceleration += new Vector3(xr, yr, zr);
        }

        if (acceleration.magnitude > maxAcceleration)
        {
            acceleration = acceleration.normalized * maxAcceleration;
        }

        period -= Time.deltaTime;
        randomPeriod -= Time.deltaTime;

        if (period < 0f) 
        return;
        velcoity += acceleration * Time.deltaTime;
        position += velcoity * Time.deltaTime;
        transform.position = position;

        //発射間隔プログラム
        timer += Time.deltaTime;

        
        
    }
}
