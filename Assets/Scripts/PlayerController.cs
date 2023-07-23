using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 1.0f;
    private Rigidbody2D rb2d;
    private SurfaceEffector2D surface;
    [SerializeField] private float baseSpeed = 20.0f;
    [SerializeField] private float boostedSpeed = 30.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surface = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        UpdateSpeed();
    }

    private void RotatePlayer()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            rb2d.AddTorque(torqueAmount);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    private void UpdateSpeed()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            surface.speed = boostedSpeed;
        }
        else
        {
            surface.speed = baseSpeed;
        }
    }
}
