using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{

    public float speed = 5;
    public float rotationSpeed = 720;
    public float jumpSpeed = 10;

    public float ySpeed;
    public Text screenText;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        DisplayText();
    }




    public void Update()
    {
        Move();      
    }

    public void Move()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, yDirection);
        float magnitude = Mathf.Clamp01(moveDirection.magnitude) * speed;
        moveDirection.Normalize();

        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            ySpeed = jumpSpeed;
        }        
        Vector3 velocity = moveDirection * magnitude;
        velocity.y = ySpeed;
        characterController.Move(velocity * Time.deltaTime);

    }

    public virtual void DisplayText()
    {
        screenText.text = "I am an animal!";
    }

}
