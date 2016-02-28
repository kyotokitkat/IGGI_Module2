using UnityEngine;
using System.Collections;

public class ComposingState : IState

{
    private readonly StatePattern bot;

    public ComposingState(StatePattern statePattern)
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
            Listen();
        }

    }

    public void ToInspirationState()
    {
        bot.currentState = bot.inspirationState;
        Debug.Log("going to inspiration state");
    }

    public void ToComposingState()
    {
        Debug.Log("Can't transition to same state");
    }

    public void ToStopState()
    {
        bot.currentState = bot.stopState;
        Debug.Log("going to stop state");
    }

    private void Listen()
    {       
       bool Heard;

        if (Random.Range(0f, 1f) > 0.98 && bot.manager.History.Count <= 50)

     
        {
            Heard = true;
            if (Heard == true)
            {
                bot.manager.History.Add(bot.clip);
                ToInspirationState();
            
            }

            else
            {
                Heard = false;
             
                ToInspirationState();
            }
        }
    }
}
    