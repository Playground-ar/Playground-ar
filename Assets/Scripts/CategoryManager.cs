using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryManager : MonoBehaviour
{
    public GameObject temolateButton;
    GameObject g;
    /*class Model3D
    {
        public string name;
        public string path;
        public int price;
        
    }*/
    // Start is called before the first frame update
    void Start()
    {
        var names = new List<string> { "Дизайн", "мебель", "Машинки" };
        Dictionary<string, List<string>> categoryes = new Dictionary<string, List<string>>();
        for (int i = 0; i < 3; i++)
        {
            categoryes.Add(names[i], names);
        }

        for (int i = 0; i < categoryes.Count; i++)
        {
            g = Instantiate(temolateButton, transform);
            g.transform.GetChild(0).GetComponent<Text>().text = "6738";
            g.transform.GetChild(1).GetComponent<Text>().text = names[i];

        }
        Destroy(temolateButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
