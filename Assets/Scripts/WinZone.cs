using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameObject FinishThrofy;
    public GameObject finishPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            GameObject finishPanel = GameObject.FindGameObjectWithTag("FinishPanel");
            if (collision.gameObject.tag == "Finish")
            {
                finishPanel.SetActive(true);

            }
        }
    }
}
