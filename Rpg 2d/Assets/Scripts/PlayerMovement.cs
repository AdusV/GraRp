using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        float hDirection = Input.GetAxis("Horizontal");
        float vDirection = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hDirection, vDirection) * speed);
    }
}
