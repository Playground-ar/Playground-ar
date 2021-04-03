using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmetaManager : MonoBehaviour
{
    public static Dictionary<string,int> smeta = new Dictionary<string, int>();
    public Text name;
    public Text count;
    // Start is called before the first frame update
    void PrintList() {
        foreach (KeyValuePair<string, int> kvp in smeta)
        {
            //textBox3.Text += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
