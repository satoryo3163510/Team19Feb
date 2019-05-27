using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [Header("シールド破壊音")]
    public AudioClip shieldDamege;
    [Header("爆発音")]
    public AudioClip destory;
    AudioSource audio;
    PlayerHp hp;
    PlayerShield shield;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        hp = GetComponent<PlayerHp>();
        shield = GetComponent<PlayerShield>();
    }

    // Update is called once per frame
    void Update()
    {
     if(hp.ReturnHP() < 0)
        {
            audio.PlayOneShot(destory);
        }
        if (shield.ReturnShield() < 0)
        {
            audio.PlayOneShot(shieldDamege);
        }
    }
}
