using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    #region singleton
    private static LevelController _instance;
    public static LevelController Instance
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
    public GameObject[] Containers;
    public int levelChange;
    public GameObject spawnManager;
    public GameObject containerManager;
    public GameObject particleManager;
    public ParticleSystem PS;

    bool isIt;
    // Start is called before the first frame update
    void Start()
    {
        isIt = false;
        foreach( var contain in Containers)
        {
            contain.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isIt == true)
        {
            OnelevelTwo();
        }
        if (levelChange == 3)
        {
            TwolevelThree();
        }
        if (levelChange == 1)
        {
            ThreelevelFour();
        }

        
        
    }

    void OnelevelTwo()
    {
        if (levelChange == 1)
        {
            Containers[0].gameObject.SetActive(true);
            spawnManager.gameObject.SetActive(false);
            containerManager.gameObject.SetActive(false);
            particleManager.gameObject.SetActive(false);
            PS.gameObject.SetActive(false);
            isIt = true;
        }
    }
    public void OnelevelTwoButton()
    {
        Containers[0].gameObject.SetActive(false);
        spawnManager.gameObject.SetActive(true);
        containerManager.gameObject.SetActive(true);
        particleManager.gameObject.SetActive(true);
        PS.gameObject.SetActive(true);
    }

    void TwolevelThree()
    {
        if (levelChange == 3)
        {
            Containers[1].gameObject.SetActive(true);
            spawnManager.gameObject.SetActive(false);
            containerManager.gameObject.SetActive(false);
            particleManager.gameObject.SetActive(false);
            PS.gameObject.SetActive(false);
        }
    }

    public void TwolevelThreeButton()
    {
        Containers[1].gameObject.SetActive(false);
        spawnManager.gameObject.SetActive(true);
        containerManager.gameObject.SetActive(true);
        particleManager.gameObject.SetActive(true);
        PS.gameObject.SetActive(true);
    }
     void ThreelevelFour()
    {
        if (levelChange == 5)
        {
            Containers[2].gameObject.SetActive(true);
            spawnManager.gameObject.SetActive(false);
            containerManager.gameObject.SetActive(false);
            particleManager.gameObject.SetActive(false);
            PS.gameObject.SetActive(false);
        }
    }

    public void ThreelevelFourButton()
    {
        Containers[2].gameObject.SetActive(false);
        spawnManager.gameObject.SetActive(true);
        containerManager.gameObject.SetActive(true);
        particleManager.gameObject.SetActive(true);
        PS.gameObject.SetActive(true);
    }

}
