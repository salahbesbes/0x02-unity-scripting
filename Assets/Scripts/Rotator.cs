using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(45 * Time.deltaTime, 0, 0);

    }
}
