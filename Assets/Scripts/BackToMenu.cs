using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    #region singleton

    private static BackToMenu _instance;
    public static BackToMenu Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("BackToMenu is null");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }



    #endregion

    [SerializeField] private GameObject Sound;
    [SerializeField] private GameObject Cross;
    [SerializeField] private GameObject baricad;
    [SerializeField] private GameObject ballSpawn;
    [SerializeField] private GameObject Container;

    [SerializeField] private GameObject backToMenu;

    public int FallCount;
    
    // Start is called before the first frame update
    void Start()
    {
        backToMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FallCount > Random.Range(10,100))
        {
            backToMenu.gameObject.SetActive(true);
            Sound.gameObject.SetActive(false);
            Cross.gameObject.SetActive(false);
            baricad.gameObject.SetActive(false);
            ballSpawn.gameObject.SetActive(false);
            Container.gameObject.SetActive(false);

            FallCount = 0;
        }

       

    }
}
