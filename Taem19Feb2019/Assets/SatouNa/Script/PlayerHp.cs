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
        if (playerHp <= 0)
        {
            ED.NextResult();
        }
    }

    public void PlayerDamage(float damage)
    {
        playerHp -= damage;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
            PlayerDamage(10f);
    }
}
