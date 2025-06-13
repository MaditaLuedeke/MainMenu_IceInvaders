using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private Vector3 direction = new Vector3(0f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.normalized * Time.deltaTime * speed;

        direction = Vector3.zero;

        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }
    }
}
