using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AirCraftCarrier : MonoBehaviour
{
    public GameObject enemyShip;
    private float timer;
    public float seisei = 5;
    public int shipCount;
    public int jougen;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        shipCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (shipCount < jougen)
        {
            timer += Time.deltaTime;
            if (timer > seisei)
            {
                GameObject ships = Instantiate(enemyShip) as GameObject;
                ships.transform.position = transform.position + new Vector3(0, 0.5f, 0);
                shipCount += 1;
                timer = 0;
            }
        }
    }
}
