using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MousePathFollow : Path
{
    public List<GameObject> PathGOs = new List<GameObject>();

    protected override Vector3 getTargetPosition()
    {
        if (PathGOs.Count == 0)
        {
            return base.getTargetPosition();
        }
        else
        {
            GameObject NextGameobject = PathGOs[0];
            Vector3 NextTarget = PathGOs[0].transform.position;
            PathGOs.RemoveAt(0);
            MonoBehaviour.Destroy(NextGameobject);
            return NextTarget;
        }
    }
}
