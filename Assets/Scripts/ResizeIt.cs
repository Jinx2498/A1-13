using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    public float movementSpeed = 1f;
    Vector3 Size;
    private bool growing = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Size = transform.localScale;
        if (growing)
        {
            if (Size.x <= 4f)
            {
                Size.x += Time.deltaTime;
                Size.y += Time.deltaTime;
                Size.z += Time.deltaTime;

                transform.localScale = Size;
            }
            else
            {
                growing = false;
            }
        }
        else
        {
            if (Size.x >= 1f)
            {
                Size.x -= Time.deltaTime;
                Size.y -= Time.deltaTime;
                Size.z -= Time.deltaTime;

                transform.localScale = Size;
            }
            else
            {
                growing = true;
            }
        }
    }
}
