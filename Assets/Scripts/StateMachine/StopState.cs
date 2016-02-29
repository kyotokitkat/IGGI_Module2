using UnityEngine;
using System.Collections;

public class StopState : IState

{
    private readonly StatePattern bot;

    public StopState(StatePattern statePattern)
    {
        bot = statePattern;
    }

    bool paused = false;

    public void UpdateState()
    {
        
            paused = togglePause();
             
          
    }

  
    public void ToInspirationState()
    {

        
        bot.currentState = bot.inspirationState;
        Debug.Log("going to inspiration state");
    }

    public void ToComposingState()
    {
        Debug.Log("Must be in InpirationState first");
    }

    public void ToStopState()
    {
        Debug.Log("Can't transition to same state");
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
           
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.P))
                ToInspirationState();
            Time.timeScale = 0f;
            return (true);
        }
        
    }
}