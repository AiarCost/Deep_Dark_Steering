using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MousePathFollwer : Kinematic
{
    MousePathFollow myMoveType;
    Face myRotateType;

    public UnityEvent<GameObject> myAddingListEvent;

    List<GameObject> CheckPoints = new List<GameObject>();

    private void Start()
    {
        myAddingListEvent = new UnityEvent<GameObject>();
        myAddingListEvent.AddListener(AddingToList);
        
        myMoveType = new MousePathFollow();
        myMoveType.character = this;    

        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;

    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
    


    public void AddingToList(GameObject go)
    {
        myMoveType.PathGOs.Add(go);
    }

}

