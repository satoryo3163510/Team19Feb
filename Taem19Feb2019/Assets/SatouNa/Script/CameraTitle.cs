using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTitle : MonoBehaviour
{
    //タイトルでカメラを回転させる
    public Transform playership;        //回転のターゲット
    [SerializeField]
    private float rotateSpeed = 10f;     //回転速度
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ターゲットの周囲を回転する
        transform.RotateAround(
            playership.position, Vector3.up,
            rotateSpeed * Time.deltaTime);
    }
}
