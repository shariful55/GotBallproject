using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoree : MonoBehaviour
{
    //private int couting;
    public Text MyScore;

    // Start is called before the first frame update
    void Start()
    {
       // couting = GameManager.Instance.gameScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountScore()
    {
        MyScore.text = "Score:  " + GameManager.Instance.gameScore; 
    }



}
