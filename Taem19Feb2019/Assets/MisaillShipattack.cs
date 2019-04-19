using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisaillShipattack : MonoBehaviour
{
    public Transform turret;
    public Transform muzzle;
    public GameObject bulletPrefad;

    private float attackInterval = 2f;
    private float turretRotationSmooth = 0.8f;
    private float lastAttackTime;

    private Transform playersenkan;
    
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
        //戦艦の位置を取得できるようにする
        playersenkan = GameObject.FindWithTag("PlayerSenkan").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(playersenkan.position - turret.position);
        turret.rotation = Quaternion.Slerp(turret.rotation, targetRotation, Time.deltaTime * turretRotationSmooth);

        //一定間隔でミサイルを発射する
        if (Time.time > lastAttackTime + attackInterval)
        {
            Instantiate(bulletPrefad, muzzle.position, muzzle.rotation);
            lastAttackTime = Time.time;
        }




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

      
        
        
    }
}
