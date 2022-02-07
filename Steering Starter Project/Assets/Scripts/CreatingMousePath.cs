using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingMousePath : MonoBehaviour
{
    public float WaitTimer = .5f;
    public GameObject SpawnPath;
    public MousePathFollwer mousePathFollower;
    float Timer = 0f;


    private void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= WaitTimer)
        {
            Vector3 Position = MousePos();
            GameObject go = Instantiate(SpawnPath, Position, Quaternion.identity);
            mousePathFollower.AddingToList(go);
            Timer = 0f;
        }
    }

    Vector3 MousePos()
    {
        Vector3 MousePos= new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0,
                              Camera.main.ScreenToWorldPoint(Input.mousePosition).z);

        return MousePos;
    }
}
