using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingletonAudio : MonoBehaviour
{
  
    public AudioClip[] Clips = new AudioClip[5];
   
    public List<AudioClip> History;
        
    public AudioSource chirp;
    
    void Awake()
    {
        History = new List<AudioClip> ();
    }

  }
