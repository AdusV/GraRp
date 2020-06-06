using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Animator anim;   
    bool dirToRight = true;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float hDirection = Input.GetAxis("Horizontal");
        float vDirection = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hDirection, vDirection) * speed);
        
        anim.SetFloat("Walk", Mathf.Abs(hDirection));
        if (hDirection < 0 && dirToRight)
        {
            Flip();
        }
        if (hDirection > 0 && !dirToRight)
        {
            Flip();
        }
        void Flip()
        {
            dirToRight = !dirToRight;
            Vector3 heroScale = gameObject.transform.localScale;
            heroScale.x *= -1;
            gameObject.transform.localScale = heroScale;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Attack");
        }
    }
}
