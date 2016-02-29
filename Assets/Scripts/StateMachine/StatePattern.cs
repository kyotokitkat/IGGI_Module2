using UnityEngine;
using System.Collections;



public class StatePattern : MonoBehaviour

{
    public SingletonAudio manager;
    public AudioClip clip;


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
        
    }
	
	// Use this for initialization
	void Start () 
	{
       currentState = inspirationState;
    }

    // Update is called once per frame
    void Update () 
	{
		currentState.UpdateState ();
	}
	
}