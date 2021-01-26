using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    private static SoundButton _instance;
    public static SoundButton Instance
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
    public Button SoundOff;
    public Button SoundOn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
