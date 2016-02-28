using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//public sealed class musicArray
public class SingletonAudio : MonoBehaviour
{
   // private static musicArray instance = null;
    //private static readonly object padlock = new object();

    public AudioClip[] Clips = new AudioClip[25];
   // public AudioClip Clip1;
    //public AudioClip Clip2;

    public List<AudioClip> History;
    //public AudioSource[] History;
    
    public AudioSource chirp;

    void Awake()
    {
        History = new List<AudioClip> ();
    }

    //public AudioClip clips; 
    
    //public Component audio;

   /* Singleton()
    {
    }

    public static musicArray Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new musicArray();
                }
                return instance;
            }
        }
    } */
}
