using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayerController : MonoBehaviour
{
    //try setting this to 8 in the inspector
    public float speed;

    //try setting this to 100 in the inspector
    public float turnSpeed;

    public float horizontalInput;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        //Move forward
        //transform.Translate(1,0);

        //Which is the same as...
        //transform.Translate(Vector2.right);

        //Move forward 20meters/second if speed is set to 20
        //transform.Translate(Vector2.right * Time.deltaTime * speed);

        //Get Input - Do this in Update()
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * Time.deltaTime * speed * verticalInput);

        //transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime * -horizontalInput);
        //Rotate player with the horizontal input
        //but reverse rotations direction when moving backwards
    if (verticalInput < 0)
        {
            transform.Rotate(Vector3.back, -turnSpeed * horizontalInput);
        }
        else
        {
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
}
