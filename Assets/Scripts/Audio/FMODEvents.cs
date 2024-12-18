using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity; 

public class FMODEvents : MonoBehaviour
{
    [field: Header("Ambience")]
    [field: SerializeField] public EventReference ambience { get; private set; }
    
    [field: Header("Music")]
    [field: SerializeField] public EventReference music { get; private set; }
    
    [field: Header("Player SFX")]
    [field: SerializeField] public EventReference playerFootsteps { get; private set; }
    [field: SerializeField] public EventReference Shoot { get; private set; } 
    [field: SerializeField] public EventReference Reload { get; private set; } 
    [field: SerializeField] public EventReference doorOpen { get; private set; } 
    [field: SerializeField] public EventReference doorClose { get; private set; } 
    
    [field: Header("Dialogue")]
    [field: SerializeField] public EventReference Announcer1 { get; private set; }
    [field: SerializeField] public EventReference Announcer2 { get; private set; }
        
    [field: Header("Zombie SFX")]
    [field: SerializeField] public EventReference Zombie { get; private set; }
    [field: SerializeField] public EventReference ZombieDeath { get; private set; }
    
    public static FMODEvents instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one AudioManager in scene.");
        }
        instance = this;
    }
}
