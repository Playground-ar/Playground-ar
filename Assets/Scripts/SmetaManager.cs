using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SmetaManager : MonoBehaviour
{
    public static Dictionary<string,int> smeta = new Dictionary<string, int>();
    public static Text name;
    public static Text count;
    public Text r;
    // Start is called before the first frame update
    public void PrintList() {
        SceneManager.LoadScene("_Smets");
        foreach (KeyValuePair<string, int> kvp in smeta)
        {
            r.text += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value) + "\n";
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
