using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RochMove : MonoBehaviour
{
    bool MoveRight = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x > 3)
        {
            MoveRight = false;
        }
        
        else if (transform.position.x < -1)
        {
            MoveRight = true;
        }
        if (MoveRight == true)
        {
            
          
           ;
            transform.Translate(2 * Vector2.right * Time.deltaTime);
            
        }
        
        else
        {
            
            
            transform.Translate(2 * Vector2.left * Time.deltaTime);
            
        }
    }
}
