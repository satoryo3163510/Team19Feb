using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    //ミサイルの挙動
    [SerializeField]
    private float firstSpeed;
    private Rigidbody rb;
    private Vector3 velosity;
    private bool EnemyEntryFlag;
    private Vector3 enemyPosition;
    private Vector3 hormingStartPosition;
    public Vector3 acceleration;
    private float period = 0.6f;
    public GameObject Ef_explosion;


    // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*firstSpeed,ForceMode.Impulse);
        EnemyEntryFlag = false;
    }

    void Update()
    {
        if (EnemyEntryFlag)
        {
            acceleration = Vector3.zero;
            var diff = enemyPosition - transform.position;
            acceleration += (diff - velosity * period) * 2f / (period * period);
            if (acceleration.magnitude > 40f)
            {
                acceleration = acceleration.normalized * 40f;
            }
            period -= Time.deltaTime;
            velosity += acceleration * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            hormingStartPosition = transform.position;
            enemyPosition = other.transform.position;
            EnemyEntryFlag = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            var hitEf = Instantiate(Ef_explosion,other.transform);
            Destroy(hitEf,1f);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + velosity * Time.deltaTime);
    }

}

    
