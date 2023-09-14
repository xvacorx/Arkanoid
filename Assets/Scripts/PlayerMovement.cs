using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 10f;
    float HorizontalMov;
    void Update()
    {
        HorizontalMov = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * HorizontalMov * Time.deltaTime * Speed);
    }
}
