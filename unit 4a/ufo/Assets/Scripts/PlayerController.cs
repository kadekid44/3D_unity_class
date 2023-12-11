using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject lazarBolt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sets horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //keeps player in the boundarys
        //left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazarBolt, blaster.transform.position, lazarBolt.transform.rotation);
        }
    }
}
