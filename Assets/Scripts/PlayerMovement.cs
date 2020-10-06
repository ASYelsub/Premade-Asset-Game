using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//From
//https://answers.unity.com/questions/1332539/how-do-i-make-the-player-rotate-left-and-right-wit.html

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float Speed = 3.0F;
    public float RotateSpeed = 3.0F;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (transform != null)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
            var forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = Speed * Input.GetAxis("Vertical");
            controller.SimpleMove(forward * curSpeed);
        }
    }
}
