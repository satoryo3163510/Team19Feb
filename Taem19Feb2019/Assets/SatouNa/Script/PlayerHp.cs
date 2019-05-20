using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    //プレイヤーのhp,hpゲージ関係
    [SerializeField]
    private float playerHp;
    [SerializeField]
    private float maxHp = 100f;
    public Slider hpGauge;
    private EasyDire ED;
    private GameObject ed;
    public GameObject EF_Die;
    private int once;
    public GameObject playerModele;
    public GameObject EF_DamageHit;

    // Start is called before the first frame update
    void Start()
    {
        ed = GameObject.Find("EasyDirector");
        ED = ed.GetComponent<EasyDire>();
        playerHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのhpを反映
        hpGauge.value = playerHp;

        //プレイヤーのHpが0以下でリザルトへ
        if (playerHp <= 0 &&once==0)
        {
            once++;
            playerModele.SetActive(false);
            var Die_ef = Instantiate(EF_Die,transform.position,Quaternion.identity);
            Destroy(Die_ef,2f);
            Invoke("GoResult", 2f);
        }
    }

    public void PlayerDamage(float damage)
    {
        playerHp -= damage;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            var damageHit = Instantiate(EF_DamageHit, transform.position, Quaternion.identity);
            Destroy(damageHit, 0.4f);
            PlayerDamage(2f);
        }
           
    }

    void GoResult()
    {
        ED.NextResult();
    }
}
