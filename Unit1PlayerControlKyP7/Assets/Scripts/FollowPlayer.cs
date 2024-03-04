using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject car;
    Vector3 caroffset = new Vector3(0, 6, -10); 
    Vector3 caroffset2 = new Vector3(0, 3.5f, 1);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = car.transform.position + caroffset;
    }

    // Late Update is called on the frame after update.
    void LateUpdate()
    {
        //offsets camera
        transform.position = car.transform.position + caroffset;

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (caroffset != caroffset2)
            caroffset = caroffset2;
            else
            caroffset = new Vector3(0,6, -10);
        
        }
    }
}
