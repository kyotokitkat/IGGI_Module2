using UnityEngine;
using System.Collections;

public interface IState
{

    void UpdateState();
    
    void ToInspirationState();

    void ToComposingState();

    void ToStopState();
}