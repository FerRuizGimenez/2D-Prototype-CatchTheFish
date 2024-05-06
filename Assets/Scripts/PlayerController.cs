using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    private bool isMoving = true;
    [SerializeField]
    private float moveSpeed;
    private Transform  myTransform;

    private float leftViewPortLimit;
    private float rightViewPortLimit;
    private float playerOffset = 1.1f;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
        // Almaceno la posicion del mundo con respecto al ViewPort
        leftViewPortLimit = Camera.main.ViewportToWorldPoint(Vector3.zero).x + playerOffset;
        rightViewPortLimit = Camera.main.ViewportToWorldPoint(Vector3.right).x - playerOffset;
    }
    private void Update()
    {
        if(isMoving)
        {
            SetMovement();
        }
        if (myTransform.position.x > rightViewPortLimit)
            SetPlayerLimitPosition(rightViewPortLimit);
        if (myTransform.position.x < leftViewPortLimit)
            SetPlayerLimitPosition(leftViewPortLimit);
    }

    private void SetPlayerLimitPosition(float limit)
    {
        myTransform.position = new Vector3(limit, transform.position.y, 0);
    }

    private void SetMovement()
    {
        float inputX = Input.GetAxis("Horizontal");
        myTransform.position += Vector3.right * (inputX * moveSpeed * Time.deltaTime);
    }
}
