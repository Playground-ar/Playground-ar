using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    public GameObject temolateButton;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(temolateButton, transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
