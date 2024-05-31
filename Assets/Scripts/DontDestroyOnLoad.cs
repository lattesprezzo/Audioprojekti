using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);        
    }
    private void Start()
    {
       // Destroy(this); // Jos halutaan destroyaa tämä kyseinen GameObjecti    
    }
}
