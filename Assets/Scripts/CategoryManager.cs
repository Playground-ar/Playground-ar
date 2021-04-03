using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CategoryManager : MonoBehaviour
{
    public GameObject temolateButton;
    private ProgrammManager ProgrammManagerScript;
    GameObject g;
    public static int cAt = 0;
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
        Dictionary<int,string> categoryes = new Dictionary<int, string>();
        for (int i = 1; i < names.Count; i++)
        {
            categoryes.Add(i, names[i]);
        }

        for (int i = 1; i < 4; i++)
        {
            g = Instantiate(temolateButton, transform);
            g.transform.GetChild(0).GetComponent<Text>().text = i.ToString();
            g.transform.GetChild(1).GetComponent<Text>().text = names[i-1];
            int copy = i;
            g.GetComponent <Button> ().onClick.AddListener (() => setCategory(copy));

        }
        Destroy(temolateButton);
    }

    void setCategory(int c)
    {
        cAt = c;
        Debug.Log((c));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
