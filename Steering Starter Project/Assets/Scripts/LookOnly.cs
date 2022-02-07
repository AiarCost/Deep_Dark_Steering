using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookOnly : Kinematic
{
    Face myRotateType;


    private void Start()
    {

        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;


    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myRotateType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
    }

}
