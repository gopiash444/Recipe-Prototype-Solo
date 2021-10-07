using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController _controller; //Allows the setting of the character controller in the inspector.
    public float speed = 10f; //Sets movement speed

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()//Controlls the players ability to move through space
    {
        float x = Input.GetAxis("Horizontal");//gets input on the x-axis for movement
        float z = Input.GetAxis("Vertical");//gets input on the y-axis for movement

        Vector3 move = transform.right * x + transform.forward * z;//controlls the Vector for actually moving through the scene
        _controller.Move(move * speed * Time.deltaTime);//makes everything framerate in-dependant.
    }
}
