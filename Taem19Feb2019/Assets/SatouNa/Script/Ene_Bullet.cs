using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_Bullet : MonoBehaviour
{
    private PlayerShield PS;
    [SerializeField]
    private float EB_damage;
    private GameObject si_rudo;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       si_rudo= GameObject.Find("si-rudo");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.gameObject==si_rudo)
        {
            PS = player.GetComponent<PlayerShield>();
            PS.ShieldDamage(EB_damage);
        }
    }
}
