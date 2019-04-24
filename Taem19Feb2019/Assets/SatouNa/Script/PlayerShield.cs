using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShield : MonoBehaviour
{
    [SerializeField]
    private float shieldHp = 1.0f;
    [SerializeField]
    private float stamina = 0.01f;

    private Slider shield;
    private GameObject player;
    private float ef_Timer = 2.0f;

    public GameObject Ef_shield;


    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield").GetComponent<Slider>();
        player = GameObject.Find("PlayerSenkan");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shieldHp -= stamina*Time.deltaTime;
            ef_Timer -= Time.deltaTime;
        }
        if (ef_Timer < 0)
        {
            GameObject efShield = Instantiate(Ef_shield, player.transform.position,
               Quaternion.identity);
            Destroy(efShield, 2.0f);
            ef_Timer = 2.0f;
        }
        shield.value = shieldHp;
    }
}
