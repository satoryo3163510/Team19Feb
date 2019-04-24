using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShield : MonoBehaviour
{
    [SerializeField]
    private float shieldHp = 100.0f;
    [SerializeField]
    private float stamina = 1.0f;
    private bool isShield;
    public Slider shieldGauge;
    public GameObject Shield;
    private bool isScopeMode;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //右クリック時にfpsならシールドを展開しない
        if (Input.GetMouseButtonDown(1))
        {
            isScopeMode = !isScopeMode;
        }
        //左クリック時にシールドが展開しているか？
        if (Input.GetMouseButtonDown(0)&&isScopeMode==false)
        {
            ShieldActive();
        }

        
        //シールド展開中は徐々に耐久値が減少
        if (isShield)
        {
            shieldHp -= stamina * Time.deltaTime;
        }
        //耐久値を反映
        shieldGauge.value = shieldHp;
    }

    //シールドを展開していたら解除し、展開していないなら展開する
    void ShieldActive()
    {
        if (Shield.activeSelf)
        {
            Shield.SetActive(!Shield.activeSelf);
            isShield = false;
        }
        else
        {
            Shield.SetActive(!Shield.activeSelf);
            isShield = true;
        }
    }
    
    //シールドへのダメージ
    public void ShieldDamage(float damage)
    {
        shieldHp -= damage;
    }
  
}
