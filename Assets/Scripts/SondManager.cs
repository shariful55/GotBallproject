using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SondManager : MonoBehaviour
{
    #region singleton
    private static SondManager _instance;
    public static SondManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("SondManager is Null");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }


    #endregion
    public static AudioSource backMusic;

    // Start is called before the first frame update
    void Start()
    {
        backMusic = GetComponent<AudioSource>();
        backMusic.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SoundOff()
    {
        if (backMusic.isPlaying == true)
        {
            backMusic.Stop();
        }
    }
    public void SoundONN()
    {
        if (backMusic.isPlaying == false)
        {
            backMusic.Play();
        }
    }

}
