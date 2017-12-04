using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDownloader : MonoBehaviour
{

    public GameObject pickUpGameObject;


	void Start ()
	{
	    Renderer renderer = pickUpGameObject.GetComponent<Renderer>();
	    renderer.sharedMaterial.mainTexture = Resources.Load("pickUpTexture") as Texture;
	}
	

}
