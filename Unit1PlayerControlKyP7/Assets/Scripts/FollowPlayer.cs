using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject car;
    Vector3 caroffset = new Vector3(0, 6, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Late Update is called on the frame after update.
    void LateUpdate()
    {
        //offsets camera
        transform.position = car.transform.position + caroffset;
    }
}
