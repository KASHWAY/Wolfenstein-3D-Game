using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform CameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = CameraPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
