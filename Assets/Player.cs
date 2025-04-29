using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 10f;

    Vector2 rawInput;

    // Update is called once per frame
    void Update()
    {
        PLayerMovement();
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
    }

    void PLayerMovement()
    {
        Vector3 delta = rawInput * PlayerSpeed * Time.deltaTime;
        transform.position += delta;
    }
}
