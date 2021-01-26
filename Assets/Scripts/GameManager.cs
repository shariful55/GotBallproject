using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region singleton
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The GameManager is Null");
            return _instance;
        }
    }
    void Awake()
    {
        _instance = this;
    }

    #endregion

    public  int gameScore=0;
    public Text myScore;
    
   
    void Start()
    {
        myScore = GetComponent<Text>();
        
    }

    public void Update()
    {
        myScore.text = "Score  " + gameScore;
    }
    
   


}
