using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChouQian : MonoBehaviour
{
    public Button btn;
    public Text tex;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(OnButton);
    }

    private void OnButton()
    {
        int n = Random.Range(1, 11);
        if(n == 1|| n==2)
        {
            tex.text = "����ǩ";
        }
        else if (n == 4 || n == 5 || n == 6)
        {
            tex.text = "��ǩ";
        }
        else
        {
            tex.text = "����ǩ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
