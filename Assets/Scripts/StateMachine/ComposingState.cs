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

        if (Random.Range(0f, 1f) > 0.6 && bot.manager.History.Count <= 30)

       //if (Random.value > 0.5)

        //&&  // History[] >= 1;
        //an audio clip was added to the History[]?

        {
            Heard = true;
            if (Heard == true)
            {
                bot.manager.History.Add(bot.clip);
                ToInspirationState();
                //dont do anything; audio clip stays in History[]
            }

            else
            {
                Heard = false;
                //remove the last sound in History[]
                ToInspirationState();
            }
        }
    }
}
    