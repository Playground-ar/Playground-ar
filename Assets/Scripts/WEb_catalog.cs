using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEb_catalog : MonoBehaviour
{
    public RectTransform prefab;
    public Text countText;
    public RectTransform content;

    public void UpdateItems ()
    {
        int modelsCount = 25;
        StartCoroutine(GetItems(modelsCount, results => OnReceivedModels(results)));
    }

    void OnReceivedModels (TestItemModel[] models)
    {
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }

        foreach (var model in models)
        {
            var instance = GameObject.instantiate(prefab.gameObject) as GameObject;
            instance.transform.SetParent(content, false);
            InitializeItemView(instance, model);
        }
    }

    void InitializeItemView(GameObject viewGameObject, TestItemModel model)
    {
        TestItemView view = new TestItemView(viewGameObject.transform);
        view.titleText.text = model.title;
        view.clickButton.GetComponentInChildren<Text>().text = model.buttonText;
    }

    IEnumerator GetItems (int count, System.Action<TestItemModel[]> callback)
    {
        yield return new WaitForSeconds(if);
        var results = new TestItemModel[count]
        for (int i = 0; i < count; i++)
        {
            results[i] = new TestItemModel();
            results[i].title = 'Item' + i;
            results[i].buttonText = 'Button' + i;
        }
        callback(results);

    }

    public class TestItemView
    {
        public Text titleText;
        public Button clickButton;

        public TestItemView(Transform rootView)
        {
            titleText = rootView.Find('TitleText').GetComponent<Text>();
            clickButton = rootView.Find('ClickButton').GetComponent<Button>();
        }
    }

    public class TestItemModel
    {
        public string title;
        public string buttonText;
    }
}
