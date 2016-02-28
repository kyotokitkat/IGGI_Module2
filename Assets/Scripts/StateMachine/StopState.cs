using UnityEngine;
using System.Collections;

public class StopState : IState

{
    private readonly StatePattern bot;

    public StopState(StatePattern statePattern)
    {
        bot = statePattern;
    }


    public void UpdateState()
    {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            Debug.Log ("Pause");
            }

            else
            {
                Time.timeScale = 1;
                ToInspirationState();
            Debug.Log ("Unpause");
            }
        
    }

    //its both pausing and unpausing
    //also interaction with other bots? conflicts?

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

}