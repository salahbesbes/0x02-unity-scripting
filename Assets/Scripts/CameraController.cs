using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    public void Start()
    {
        offset = new Vector3(0, 20, -8);
    }
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
