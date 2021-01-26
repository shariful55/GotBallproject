using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    private static Options _instance;
    public static Options Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("SoundButton is Null");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }


    public GameObject OptionManu3;
    public GameObject Cross;

    void Start()
    {
        //OptionManu3 = GameObject.Find("PopOption") as GameObject;
        //Cross = GameObject.Find("Cross") as GameObject;
        OptionManu3.SetActive(false);
        Cross.SetActive(false);

    }

}
