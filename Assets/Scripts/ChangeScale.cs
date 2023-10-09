using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    float escalaX;
    float escalaY;
    float escalaZ = 0.7f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Reduce"))
        {
            
            transform.localScale = new Vector3(escalaX + 0.2f, escalaY + 0.2f,escalaZ);
  
        }
        if (collision.gameObject.CompareTag("Key"))
        {

            GameObject wall = GameObject.FindGameObjectWithTag("Wall");
            Destroy(wall); 
            Destroy (collision.gameObject);

        }
    }
}
