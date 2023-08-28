using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    Vector3 pos = new Vector3(0, 5, -10);
    
    void Update()
    {
        transform.position = player.transform.position + pos;
    }
}
