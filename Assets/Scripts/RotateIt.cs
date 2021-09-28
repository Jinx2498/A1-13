using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // rotate (30, 60, 90) per second
        transform.Rotate(30 * Time.deltaTime,
            60 * Time.deltaTime,
            90 * Time.deltaTime);
    }
}
