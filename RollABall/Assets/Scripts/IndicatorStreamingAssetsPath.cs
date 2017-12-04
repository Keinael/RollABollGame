using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IndicatorStreamingAssetsPath : MonoBehaviour
{
    public string filePath;
    public string result;


    void Start()
    {
        filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "new.txt");
        result = "";
        StartCoroutine(Example());
        Debug.Log(result);
    }

    IEnumerator Example()
    {
        if (filePath.Contains("://"))
        {
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.SendWebRequest();
            result = www.downloadHandler.text;
        }
        else
        {
            result = System.IO.File.ReadAllText(filePath);
        }
    }
}