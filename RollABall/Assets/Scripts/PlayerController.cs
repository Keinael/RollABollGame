using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    public float speed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate ()
    {
        float moveAxisX = Input.GetAxis("Horizontal");
        float moveAxisZ = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveAxisX, 0.0f, moveAxisZ);

        rb.AddForce(movement * speed);
    }    
}
