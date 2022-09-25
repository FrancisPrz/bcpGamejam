using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public Animator anim;
    private Vector2 playerInput;
    public Rigidbody rgbd;
    public float rotationSpeed;

    void Start()
    {
        rgbd = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Move();
        PlayerRotation();
        
    }

    public void Move()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rgbd.velocity = new Vector3(playerInput.x * speed * Time.fixedDeltaTime, rgbd.velocity.y, playerInput.y * speed * Time.fixedDeltaTime);

        if (rgbd.velocity.magnitude > maxSpeed)
        {
            rgbd.velocity = Vector3.ClampMagnitude(rgbd.velocity, maxSpeed);
        }

        if (rgbd.velocity.x != 0 || rgbd.velocity.z != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }
    private void PlayerRotation()
    {
        Vector3 targetDirection = Vector3.zero;

        targetDirection = Camera.main.transform.forward * playerInput.y;
        targetDirection += Camera.main.transform.right * playerInput.x;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero) targetDirection = transform.forward;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;

    }
}
