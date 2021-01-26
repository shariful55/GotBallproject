using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    private static VFXManager _instance;
    public static VFXManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("VFXManager is null!");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
    public ParticleSystem destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
