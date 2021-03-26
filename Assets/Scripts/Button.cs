using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//скрипт: при нажатии на экран смартфона объект появляется или исчезает
public class Button:MonoBehaviour
{
    public GameObject Cube;
    public bool act;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (act == true)
            {
                Cube.SetActive(false);
                act = true
            }
            else
            {
                Cube.SetActive(true);
                act = false
            }
        }
    }
}