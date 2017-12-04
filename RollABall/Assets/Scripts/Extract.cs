using UnityEngine;
using System.Collections;


public class Extract : MonoBehaviour
{
    public Texture Texture;

    public void Start()
    {
        StartCoroutine(Extraction());
    }

    private IEnumerator Extraction()
    {
        using(WWW www = WWW.LoadFromCacheOrDownload("https://www.dropbox.com/s/w38qyz7ddry4el1/texturemaps?dl=1", 0))
        {
            while(!www.isDone)
            {
                Debug.Log(www.progress);
                yield return null;
            }

            yield return www;

            AssetBundle bundle = www.assetBundle;

            AssetBundleRequest request = bundle.LoadAssetAsync("airbaloon");

            yield return request;

            Texture = request.asset as Texture;

            bundle.Unload(false);
        }

        GameObject player = GameObject.Find("Player");

        player.GetComponent<Renderer>().material.mainTexture = Texture;
    }
}
