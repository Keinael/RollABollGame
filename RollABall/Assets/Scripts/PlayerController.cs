using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody _rb;
    private int _count;

    public float speed;
    public Text countText;
    public Text winText;
    public GameObject helperObj;
    private readonly int count;

    public object rb { get; private set; }

    void Start()
    {  
        _rb = GetComponent<Rigidbody>();
        _count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveAxisX = Input.GetAxis("Horizontal");
        float moveAxisZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAxisX, 0.0f, moveAxisZ);

        _rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            other.gameObject.SetActive(false);
            _count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + _count.ToString();
        if (_count >= 12)
        {
            helperObj.GetComponent<AudioSource>().Play();
            winText.text = "You Win!";
        }
    }
}
