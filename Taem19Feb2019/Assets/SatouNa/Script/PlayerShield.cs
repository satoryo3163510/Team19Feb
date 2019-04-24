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

    public Slider shieldGauge;
    private GameObject player;
    public GameObject Shield;
    public bool isShield;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&Shield.activeSelf)
        {
            Shield.SetActive(!Shield.activeSelf);
            isShield = false;
        }
        else if(Input.GetMouseButtonDown(0)&&Shield.activeSelf==false)
        {
            Shield.SetActive(!Shield.activeSelf);
            isShield = true;
        }

        if (isShield)
        {
            shieldHp -= stamina * Time.deltaTime;
        }
        shieldGauge.value = shieldHp;
    }
}
