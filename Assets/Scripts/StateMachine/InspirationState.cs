using UnityEngine;
using System.Collections;

public class InspirationState : IState

    
{
	private readonly StatePattern bot;
   

    public InspirationState (StatePattern statePattern)
	{
		bot = statePattern;

    }

    public void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToStopState();
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

        if (Random.Range (0f,1f) > 0.95)
  
        {
            Sound = true;
            if (Sound == true)
            {
                
                bot.clip = (bot.manager.Clips[Random.Range(0, bot.manager.Clips.Length)]);                
                bot.manager.chirp.PlayOneShot(bot.clip);
                              
      
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