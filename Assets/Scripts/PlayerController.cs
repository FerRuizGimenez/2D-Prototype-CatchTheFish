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
    private void Update()
    {
        if(isMoving)
        {
            SetMovement();
        }
    }
    private void SetMovement()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * (inputX * moveSpeed * Time.deltaTime);
    }
}
