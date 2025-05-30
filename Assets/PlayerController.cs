using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;

    private int health = 3;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, playerRigidbody.linearVelocity.y, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;
        if (Input.GetKey(KeyCode.Space) == true)
        {
            Die();
        }
    }

    public void Die()
    {
        health -= 1;
        if( health <= 0) { 
            gameObject.SetActive(false);
        }
    }
}
