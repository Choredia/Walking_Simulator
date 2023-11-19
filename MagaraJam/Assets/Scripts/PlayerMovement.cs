using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 movement;
    [SerializeField] private float walkSpeed = 5f;
    private float xValue;
    private float zValue;
    private float playerSpeed;

    private Vector3 velocity;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerSpeed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Gravity();

        Movement();

        characterController.Move(velocity * Time.deltaTime);
    }

    private void Gravity()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -5f; // Yere deðilken hafif bir kuvvet uygula
        }

        if (!isGrounded && Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 3f, groundMask))
        {
            // Merdivene raycast yapýyoruz ve raycast'in çarptýðý nesne varsa ve karakter havadaysa yerçekimi etkisini kapatýyoruz.
            velocity.y = 0f;
        }
        else
        {
            // Yerçekimi etkisi
            velocity.y += gravity * Time.deltaTime;
        }

        // Yerde deðilken yerçekimini uygula
        
    }

    private void Movement()
    {
        xValue = Input.GetAxisRaw("Horizontal");
        zValue = Input.GetAxisRaw("Vertical");

        movement = transform.right * xValue + transform.forward * zValue;

        if (movement != Vector3.zero)
        {
            characterController.Move(playerSpeed * Time.deltaTime * movement.normalized);
            
            //ses
        }
        else
        {
            
            //ses
        }

    }
}
