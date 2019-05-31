using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonClick : MonoBehaviour
{
    public GameObject UiAll;
    public Text CreditText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_T()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnClick_E()
    {
        SceneManager.LoadScene("Easy");
    }

    public void OnClick_H()
    {
        SceneManager.LoadScene("Hard");
    }

    public void OnClick_I()
    {
        SceneManager.LoadScene("Irregular");
    }

    public void OnClick_C()
    {
        CreditText.enabled = true;
        UiAll.SetActive(false);
    }
}
