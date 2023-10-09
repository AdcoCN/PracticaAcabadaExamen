using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMove : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb2D;
    private Vector2 moveImput;
   
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveImput= new Vector2(moveX, moveY);   
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + moveImput * speed * Time.fixedDeltaTime);
    }
}
