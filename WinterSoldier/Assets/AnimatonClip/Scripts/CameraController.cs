using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 6.0f, target.position.z - 5.0f);
    }
}
