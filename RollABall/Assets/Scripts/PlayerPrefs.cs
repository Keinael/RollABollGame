using UnityEngine;

public class PlayerPrefs : MonoBehaviour {

    private float _playerCoordinatesX;
    private float _playerCoordinatesY;
    private float _playerCoordinatesZ;

    public GameObject playerObj;

    void Update ()
	{
	    if (Input.GetKeyUp(KeyCode.K))
	    {
	        _playerCoordinatesX = playerObj.transform.position.x;
	        _playerCoordinatesY = playerObj.transform.position.y;
	        _playerCoordinatesZ = playerObj.transform.position.z;
            Debug.Log(_playerCoordinatesX);
	        Debug.Log(_playerCoordinatesY);
	        Debug.Log(_playerCoordinatesZ);
            UnityEngine.PlayerPrefs.SetFloat("xCoordinate", _playerCoordinatesX);
	        UnityEngine.PlayerPrefs.SetFloat("yCoordinate", _playerCoordinatesY);
	        UnityEngine.PlayerPrefs.SetFloat("zCoordinate", _playerCoordinatesZ);
        }

	    if (Input.GetKeyUp(KeyCode.L))
	    {
	        playerObj.GetComponent<Transform>().position = new Vector3(UnityEngine.PlayerPrefs.GetFloat("xCoordinate"), UnityEngine.PlayerPrefs.GetFloat("yCoordinate"), UnityEngine.PlayerPrefs.GetFloat("zCoordinate"));
        }
    }
}
