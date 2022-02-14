using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    //this camera's position matches car position
    [SerializeField] private GameObject thingToFollow;
    void Update()
    {
        //transform.position = thingToFollow().position;
    }
    
}
