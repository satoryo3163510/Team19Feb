using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    //エネミーのHp,消滅関係
    [SerializeField]
    private float enemyHp;
    [SerializeField]
    private float maxEnemyHp = 100f;
    public GameObject EF_explode_2;
    public GameObject EF_damage;
    new AudioSource audio;
    [Header("ヒット音")]
    public AudioClip audioDamage;
    [Header("爆発音")]
    public AudioClip audioDestory;
    public bool isdead;

    // hpの初期化
    void Start()
    {
        enemyHp = maxEnemyHp;
        audio = GetComponent<AudioSource>();
        isdead = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnemyDamage(float damage)
    {
        enemyHp -= damage;
        if (enemyHp <= 0)
        {
            var ef_explode2 = Instantiate(EF_explode_2, transform.position, Quaternion.identity);
            Destroy(ef_explode2, 1f);
            Destroy(gameObject, 0.4f);
            audio.PlayOneShot(audioDestory);
            isdead = true;
        }
        else
        {
            var ef_damage = Instantiate(EF_damage, transform.position, Quaternion.identity);
            Destroy(ef_damage, 1f);
            audio.PlayOneShot(audioDamage);
        }
    }
    public float Return()
    {
        return enemyHp;
    }
}
