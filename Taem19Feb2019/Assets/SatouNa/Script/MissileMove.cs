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
    private Transform enemyPosition;
    private Vector3 hormingStartPosition;
    public Vector3 acceleration;
    private float period = 0.6f;
    public GameObject Ef_explosion;


    // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*firstSpeed,ForceMode.Impulse);
    }

    void Update()
    {
        if (EnemyEntryFlag)
        {
            acceleration = Vector3.zero;
            var diff = enemyPosition.position - transform.position;
            acceleration += (diff - velosity * period) * 2f / (period * period);
            if (acceleration.magnitude > 100f)
            {
                acceleration = acceleration.normalized * 100f;
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
            enemyPosition = other.transform;
            EnemyEntryFlag = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            var hitEf = Instantiate(Ef_explosion,other.transform);
            Destroy(hitEf, 1f);
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + velosity * Time.deltaTime);
    }

}

    
