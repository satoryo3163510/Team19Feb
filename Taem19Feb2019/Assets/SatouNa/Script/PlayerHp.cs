using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    [SerializeField]
    private float playerHp;
    [SerializeField]
    private float maxHp = 100f;
    public Slider hpGauge;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        playerHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのhpを反映
        hpGauge.value = playerHp;
    }

    public void PlayerDamage(float damage)
    {
        playerHp -= damage;
    }
}
