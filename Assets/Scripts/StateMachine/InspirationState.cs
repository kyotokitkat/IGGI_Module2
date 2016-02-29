using UnityEngine;
using System.Collections;

public class InspirationState : IState

    
{
	private readonly StatePattern bot;
   

    public InspirationState (StatePattern statePattern)
	{
		bot = statePattern;

    }
    static GameObject bird;
    public GameObject[] birds;


    public void UpdateState()
    {
        birds = GameObject.FindGameObjectsWithTag("bird");

        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (GameObject bird in birds)
            {
                ToStopState();
            }
        }
        else
        {
            Think();
        }
    }
    
    public void ToInspirationState()
	{
        Debug.Log("Can't transition to same state");
    }

    public void ToComposingState()
	{
        bot.currentState = bot.composingState;
        Debug.Log("going to composing state");
    }

    public void ToStopState()
	{
       bot.currentState = bot.stopState;
        Debug.Log("going to stop state");
    }

    
    private void Think()
    {
        bool Sound;

        if (Random.Range(0f, 1f) > 0.99)

        {
            Sound = true;
            if (Sound == true)
            {
                foreach (GameObject bird in birds)
                {
                    bot.clip = (bot.manager.Clips[Random.Range(0, bot.manager.Clips.Length)]);
                    bot.manager.chirp.PlayOneShot(bot.clip);
                }

            }
            ToComposingState();

        }
        else
        {
            Sound = false;           
            UpdateState();
        }
        
              
    }

    
}