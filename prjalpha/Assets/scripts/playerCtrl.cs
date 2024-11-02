using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float verticalSpeed;
    public float turnSpeed;
    public float jumpForce; 
    private Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * verticalSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
