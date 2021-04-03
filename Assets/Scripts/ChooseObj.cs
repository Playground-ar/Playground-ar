using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseObj : MonoBehaviour
{
    private ProgrammManager ProgrammManagerScript;
    private Button button;
    public GameObject ChosenObject;
    public int price = 0;
    public string name;
    void Start()
    {
        ProgrammManagerScript = FindObjectOfType<ProgrammManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ChooseObjectFunction);
    }

    // Update is called once per frame
    void ChooseObjectFunction()
    {
        ProgrammManagerScript.ObjectToSpawn = ChosenObject;
        ProgrammManagerScript.ChOb = true;
    }
}