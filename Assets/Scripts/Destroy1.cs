using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy1 : MonoBehaviour
{
    #region singleton
    public static Destroy1 _instance;
    public static Destroy1 Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Destroy is Null");
            return _instance;
        }
    }
    
    // Start is called before the first frame update

    void Awake()
    {
        _instance = this;
    }
    #endregion


    
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -4)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("cube"))
        {
            GameManager.Instance.gameScore += 1;
            VFXManager.Instance.destroyEffect.Play();
            Destroy(this.gameObject);
            Barricade.Instance.cont++;


        }
         if (col.gameObject.CompareTag("ground"))
        {
            Destroy(this.gameObject);
            BackToMenu.Instance.FallCount += 1;
        }
        
    }
}
