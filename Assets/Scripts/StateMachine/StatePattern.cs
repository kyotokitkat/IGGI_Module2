using UnityEngine;
using System.Collections;



public class StatePattern : MonoBehaviour

{
    public SingletonAudio manager;
    public AudioClip clip;
    //public AudioClip Clip1;
    //public AudioClip Clip2;

    //public AudioSource[] History;


    //public AudioSource audio;
   //AudioSource audio = clips;

    // private AudioSource source;

    [HideInInspector] public IState currentState;
	[HideInInspector] public StopState stopState;
	[HideInInspector] public ComposingState composingState;
	[HideInInspector] public InspirationState inspirationState;
	
	
	private void Awake()
	{
        manager = GameObject.Find("ManagerObj").GetComponent<SingletonAudio>();

		inspirationState = new InspirationState (this);
		composingState = new ComposingState (this);
		stopState = new StopState (this);



        //audio = GetComponent<AudioSource>();
    }
	
	// Use this for initialization
	void Start () 
	{
       // Clips = GetComponents<AudioClip>();
        //Clip1 = Clips[0];
        //Clip2 = Clips[1];

        currentState = inspirationState;
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentState.UpdateState ();
	}
	
}