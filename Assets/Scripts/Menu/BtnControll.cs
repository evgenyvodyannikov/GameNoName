using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //������ � ������������
using UnityEngine.SceneManagement; //������ �� �������
using UnityEngine.Audio; //������ � �����

public class BtnControll : MonoBehaviour
{


    public GameObject settings;
    public GameObject menu;


    // Start is called before the first frame update
    void Start()
    {
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToSettings()
    {
        menu.SetActive(false);
    }

    public void GoToMenu()
    {
        menu.SetActive(true);
    }
}

