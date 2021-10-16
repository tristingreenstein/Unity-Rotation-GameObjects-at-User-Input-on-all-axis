using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float speed_value = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(speed_value, 0, 0));
           // Debug.Log("You Pressed X");
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.Rotate(new Vector3(0, speed_value, 0));
           // Debug.Log("You Pressed Y");
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, speed_value));
           // Debug.Log("You Pressed Z");
        }
        if (Input.GetKeyUp("up") && speed_value < 20)
        {
            speed_value += 1.0f;
            //Debug.Log("You Pressed Up Key");
            Debug.Log("Speed: " + speed_value);
        }
        if (Input.GetKeyUp("down") && speed_value > 0)
        {
            speed_value -= 1.0f;
            // Debug.Log("You Pressed Down Key");
            Debug.Log("Speed: " + speed_value);
        }
    }
}
