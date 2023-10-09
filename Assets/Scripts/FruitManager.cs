using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text TotalFruits;
    public Text FruitsCollected;
    private int TotalFruitsInLevel;
    private void Start()
    {
        TotalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        //AllFruitsCollected();
        //TotalFruits.text = TotalFruitsInLevel.ToString();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 1)
        {
            Debug.Log("No quedan frutas, Victoria");
        }
    }



}
