using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageModels : MonoBehaviour
{
    private GameObject buttska;
    private GameObject pref;
    void Start()
    {
        buttska = GameObject.Find("Skameika");
        pref = (GameObject)Resources.Load("Assets/Prefabs/Машинки/D 19_3", typeof(GameObject));
        buttska.GetComponent<ChooseObj>().ChosenObject = pref; 

    }

    void Update()
    {
        
    }
}

// Назначить перфа веместо null (строка 12)