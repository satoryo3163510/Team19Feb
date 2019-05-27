using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject originalPart, phantom;
    private Transform CT, CB;
    private float time;
    GameObject part1, part2;
    bool isShot;
    public int interval = 30;
    public float lifetime;
    public float tamahayasa = 500;
    // Start is called before the first frame update
    void Start()
    {
        CT = GameObject.Find("taihou_ue").transform;
        CB = GameObject.Find("taihou_sita").transform;
        time = 0;
        isShot = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            time += Time.deltaTime;
            if (time > interval)
            {
                isShot = true;
                if (isShot)
                {
                    part1 = Instantiate(originalPart) as GameObject;
                    part2 = Instantiate(originalPart) as GameObject;
                    part1.transform.position = CT.position;
                    part1.transform.rotation = CT.rotation;
                    part2.transform.position = CB.position;
                    part2.transform.rotation = CB.rotation;
                    part1.transform.Rotate(new Vector3(0, 90, 0));
                    part2.transform.Rotate(new Vector3(0, 90, 0));
                    time = 0;
                    Destroy(part1, lifetime);
                    Destroy(part2, lifetime);

                    GameObject bullets = Instantiate(phantom) as GameObject;
                    Vector3 force = gameObject.transform.right * tamahayasa;
                    bullets.GetComponent<Rigidbody>().AddForce(force);
                    bullets.transform.position = gameObject.transform.position;
                    bullets.transform.rotation = gameObject.transform.rotation;
                    
                    Destroy(bullets, lifetime);
                }
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            time = 0;
            isShot = false;
        }
    }
}
