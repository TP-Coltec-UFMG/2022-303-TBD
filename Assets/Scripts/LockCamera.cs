using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
    public Transform FollowObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(FollowObject.position.x + 6, transform.position.y, transform.position.z);
        transform.position = pos;
    }
}