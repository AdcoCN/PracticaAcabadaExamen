using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    public AudioSource clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            FindObjectOfType<FruitManager>().AllFruitsCollected();

            Destroy(gameObject, 0.5f);

            clip.Play();


        }
    }



}
