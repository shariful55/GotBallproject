using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    #region singleton

    private static Barricade _instance;
    public static Barricade Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Barricade is null");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
    #endregion
    private float Timer;
  [SerializeField] private GameObject [] Grounds;
  [SerializeField]  private GameObject initialGround; 

  [SerializeField] private GameObject [] BackGrounds;
  [SerializeField]  private GameObject initialBackGround; 
    
  [SerializeField] private GameObject [] barricades;
  [SerializeField]  private GameObject initialBaricade;
  [SerializeField] private int barCount;
   public int cont;


    // Start is called before the first frame update
    void Start()
    {
        barCount = Random.Range(5, 50);
        foreach(var ground in Grounds)
        {
            ground.gameObject.SetActive(false);
        }
        
        foreach(var backGround in BackGrounds)
        {
            backGround.gameObject.SetActive(false);
        }

        foreach(var baricade in barricades)
        {
            baricade.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        #region grounds
        if (Timer > 10)
        {
            initialGround.gameObject.SetActive(false);
            Grounds[0].gameObject.SetActive(true);
        }
        if (Timer > 20)
        {
            Grounds[0].gameObject.SetActive(false);
            Grounds[1].gameObject.SetActive(true);
        }
        if (Timer > 30)
        {
            Grounds[1].gameObject.SetActive(false);
            Grounds[2].gameObject.SetActive(true);
        }
         if (Timer > 40)
        {
            Grounds[2].gameObject.SetActive(false);
            Grounds[3].gameObject.SetActive(true);
        }
         if (Timer > 50)
        {
            Grounds[3].gameObject.SetActive(false);
            Grounds[4].gameObject.SetActive(true);
        }
         if (Timer > 60)
        {
            Grounds[4].gameObject.SetActive(false);
            Grounds[5].gameObject.SetActive(true);
        } 
        
        if (Timer > 70)
        {
            Grounds[5].gameObject.SetActive(false);
            Grounds[6].gameObject.SetActive(true);
        }
        if (Timer > 80)
        {
            Grounds[6].gameObject.SetActive(false);
            Grounds[7].gameObject.SetActive(true);
        }
        if (Timer > 90)
        {
            Grounds[7].gameObject.SetActive(false);
            Grounds[8].gameObject.SetActive(true);
        }
         if (Timer > 100)
        {
            Grounds[8].gameObject.SetActive(false);
            Grounds[9].gameObject.SetActive(true);
        }
          if (Timer > 100)
        {
            Grounds[9].gameObject.SetActive(false);
            initialGround.gameObject.SetActive(true);
            Timer = 0;
        }
        #endregion
        #region   //background changes

        if (Timer > 5)
        {
            initialBackGround.gameObject.SetActive(false);
            BackGrounds[0].gameObject.SetActive(true);
        }
           if (Timer > 15)
        {
            BackGrounds[0].gameObject.SetActive(false);
            BackGrounds[1].gameObject.SetActive(true);
        }
         if (Timer > 20)
        {
            BackGrounds[1].gameObject.SetActive(false);
            BackGrounds[2].gameObject.SetActive(true);
        }
         if (Timer > 25)
        {
            BackGrounds[2].gameObject.SetActive(false);
            BackGrounds[3].gameObject.SetActive(true);
        }
         if (Timer > 30)
        {
            BackGrounds[3].gameObject.SetActive(false);
            BackGrounds[4].gameObject.SetActive(true);
        }
         if (Timer > 35)
        {
            BackGrounds[4].gameObject.SetActive(false);
            BackGrounds[5].gameObject.SetActive(true);
        }
         if (Timer > 40)
        {
            BackGrounds[5].gameObject.SetActive(false);
            BackGrounds[6].gameObject.SetActive(true);
        }
         if (Timer > 45)
        {
            BackGrounds[6].gameObject.SetActive(false);
            BackGrounds[7].gameObject.SetActive(true);
        }
         if (Timer > 50)
        {
            BackGrounds[7].gameObject.SetActive(false);
            BackGrounds[8].gameObject.SetActive(true);
        }
         if (Timer > 55)
        {
            BackGrounds[8].gameObject.SetActive(false);
            BackGrounds[9].gameObject.SetActive(true);
        }
         if (Timer > 60)
        {
            BackGrounds[9].gameObject.SetActive(false);
            BackGrounds[10].gameObject.SetActive(true);
        }
          if (Timer > 65)
        {
            BackGrounds[10].gameObject.SetActive(false);
            BackGrounds[11].gameObject.SetActive(true);
        }
          if (Timer > 70)
        {
            BackGrounds[11].gameObject.SetActive(false);
            BackGrounds[12].gameObject.SetActive(true);
        }
          if (Timer > 80)
        {
            BackGrounds[12].gameObject.SetActive(false);
            initialBackGround.gameObject.SetActive(true);
            Timer = 0;
        }

        #endregion

        #region obstacle
        if (cont > 10)
        {
            initialBaricade.gameObject.SetActive(false);
            barricades[0].gameObject.SetActive(true);
        }
        if (cont > 40)
        {
            barricades[0].gameObject.SetActive(false);
            barricades[1].gameObject.SetActive(true);
        }
         if (cont > 85)
        {
            barricades[1].gameObject.SetActive(false);
            barricades[2].gameObject.SetActive(true);
        }
         if (cont > 120)
        {
            barricades[2].gameObject.SetActive(false);
            barricades[3].gameObject.SetActive(true);
        }
         if (cont > 200)
        {
            barricades[3].gameObject.SetActive(false);
            barricades[4].gameObject.SetActive(true);
        }
         if (cont > 250)
        {
            barricades[4].gameObject.SetActive(false);
            barricades[5].gameObject.SetActive(true);
        }
         if (cont > 300)
        {
            barricades[5].gameObject.SetActive(false);
            barricades[6].gameObject.SetActive(true);
        }
         if (cont > 400)
        {
            barricades[6].gameObject.SetActive(false);
            barricades[7].gameObject.SetActive(true);
        }
         if (cont > 500)
        {
            barricades[7].gameObject.SetActive(false);
            initialBaricade.gameObject.SetActive(true);
            cont = 0;
        }

        #endregion

    }
}
