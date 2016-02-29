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

    //private void Start()
    //   {
    //      Time.timeScale = 1f;
    // }

    public void UpdateState()
    {
        
            paused = togglePause();
        /* if (paused)
        {
            
            Time.timeScale = 0f;
            return
            Debug.Log("pause");
        }

        else
        {
            paused = true;
           // Time.timeScale = 1f;
            ToInspirationState();
        } */
        // if (Input.GetKeyDown(KeyCode.P)) //check if Escape key/Back key is pressed

        /* if (paused)
             paused = false;  //unpause the game if already paused
         else
              paused = true;  //pause the game if not paused


          if (paused)

          {
              Time.timeScale = 0f;
              Debug.Log("pause");
          }
          //set the timeScale to 0 so that all the procedings are halted

          else
          {
             ToInspirationState(); */

        /*}

         if (Time.timeScale == 1f)
         {
             Time.timeScale = 0f;
         Debug.Log ("Pause");
         }

         else
         {
             Time.timeScale = 1f;
             ToInspirationState();
         Debug.Log ("Unpause");
         } */

        //}
    }

    //its both pausing and unpausing
    //also interaction with other bots? conflicts?

    public void ToInspirationState()
    {

        //Time.timeScale = 1f;     //set it back to 1 on unpausing the game
        // Debug.Log("unpause");
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