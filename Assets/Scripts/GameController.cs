using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region singleton
    private static GameController _instance;
    public static GameController Instance
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

    public GameObject backToManu;
    public GameObject Sound;
    public GameObject ballSpawn;

    public int chances;
    // Start is called before the first frame update
    void Start()
    {

        backToManu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //if (chances == 5)
        //{
        //   // backToManu.gameObject.SetActive(true);
        //    Sound.gameObject.SetActive(false);
        //    ballSpawn.gameObject.SetActive(false);
        //    chances = 0;

        //}
    }
}
