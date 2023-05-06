using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public bool aiActive = true;
    public State currentState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( !aiActive )
        {
            return;
        }

        currentState.UpdateState(this);
    }

    private void OnDrawGizmos()
    {
        if( currentState != null )
        {
            Gizmos.color = Color.red;
        }
    }
}
