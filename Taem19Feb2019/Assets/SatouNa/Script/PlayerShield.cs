using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShield : MonoBehaviour
{
    public GameObject Shield;
    private bool isScopeMode;
    public Slider shieldGauge;
    [SerializeField]
    private float shieldHp = 1.0f;
    [SerializeField]
    private float maxShieldHp = 100.0f;
    [SerializeField]
    private float regene = 0.2f;
    private float stamina = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        shieldHp = maxShieldHp;
    }

    // Update is called once per frame
    void Update()
    {
        //右クリック時に一人称視点と三人称視点を切り替えるフラグ
        if (Input.GetMouseButtonDown(1))
                isScopeMode = !isScopeMode;

        //左クリック時にシールドが展開しているか？
        if (Input.GetMouseButtonDown(0)&&isScopeMode==false)
                ShieldActive();

        //シールド展開中は徐々に耐久値が減少
        if (Shield.activeSelf)
        {
            if (shieldHp < 0)
            { 
                shieldHp = 0;
                Shield.SetActive(false);
            }
            else
            shieldHp -= stamina * Time.deltaTime;

            //耐久値を反映
            shieldGauge.value = shieldHp;
        }
        else
            ShieldGenerate();
    }

    //シールドを展開していたら解除し、展開していないなら展開する
    //シールドの耐久値が０なら解除せれる
    void ShieldActive()
    {
        if (Shield.activeSelf)
            Shield.SetActive(!Shield.activeSelf);
        else if (!Shield.activeSelf)
            Shield.SetActive(!Shield.activeSelf);
    }

    //シールドへのダメージ
    public void ShieldDamage(float damage)
    {
        if (shieldHp < 0)
                shieldHp = 0;
        else
            shieldHp -= damage;
        shieldGauge.value = shieldHp;
    }

    //シールドの自然回復
    public void ShieldGenerate()
    {
        if (maxShieldHp >= shieldHp)
            shieldHp += regene * Time.deltaTime;
        else
            shieldHp = maxShieldHp;
        shieldGauge.value = shieldHp;
    }
}
