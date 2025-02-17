﻿using UnityEngine;
using System.Collections;

public class ObjectTracker : MonoBehaviour {
    public GameObject objectToTrack; 
    public bool lockX;
    public bool lockY;
    public bool lockZ;

    private Vector3 originalObjectPosition;
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start ()
    {
        originalObjectPosition = objectToTrack.transform.position;
        offset = transform.position - objectToTrack.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate ()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        var position = objectToTrack.transform.position + offset;

        if (lockX) {
            position.x = originalObjectPosition.x + offset.x;
        }
        if (lockY) {
            position.y = originalObjectPosition.y + offset.y;
        }
        if (lockZ) {
            position.z = originalObjectPosition.z + offset.z;
        }

        transform.position = position;
    }

}