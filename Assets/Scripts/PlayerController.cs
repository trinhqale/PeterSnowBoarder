using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 1.0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
}
