using UnityEngine;
using System.Collections;

public class InspirationState : IState

    
{
	private readonly StatePattern bot;
    /*public AudioClip[] Clips = new AudioClip[25];
    public AudioClip Clip1;
    public AudioClip Clip2;

    public AudioSource[] History;
    private AudioSource chirp;
    public AudioClip clips;
    //public Component audio; */


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

        if (Random.Range (0f,1f) > 0.6)
        // if (Random.value > 0.6)
        {
            Sound = true;
            if (Sound == true)
            {
                // float vol = Random.Range(0, Clips.length);
                //  source.PlayOneShot(shootSound, vol);

                //int ran = Random.Range(0, Clips.length);
                //chirp.clip = Clips[ran];
                //chirp.Play();

                bot.clip = (bot.manager.Clips[Random.Range(0, bot.manager.Clips.Length)]);
                bot.manager.chirp.PlayOneShot(bot.clip);
                // bot.manager.chirp.PlayOneShot(bot.manager.clips[Random.Range(0, musicArray.Instance.Clips.Length)]);

                //  if (audio.isPlaying) return;
                // audio.clip = Clips.[Random.Range(0, Clips.length)];
                // audio.Play();

                //nextClips.PlayOneShot(bot.Clips [Random.Range(0, musicArray.instance.ength)]);


                //int random = Random.Range(0,clips.Length);
                //audio.PlayOneShot(clips[random]);
            }
            //add the audio clip to the History[]
            ToComposingState();
            
        }
            else
        {
            Sound = false;
            UpdateState();
        } 

         //has a sound been made
        //if true go to Think();
        //if false return to UpdateState();
    }

    
}