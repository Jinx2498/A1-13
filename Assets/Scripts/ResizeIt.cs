using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    public float movementSpeed = 1f;
    Vector3 Size;
    public bool x = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        while(x == true) {
            if(Size.x != 4f) {

                Size = transform.localScale;

                Size.x += Time.deltaTime;
                Size.y += Time.deltaTime;
                Size.z += Time.deltaTime;

                transform.localScale = Size;

            } else if(Size.x == 4f) {
                
                while(Size.x != 1f) {
            
                    Size = transform.localScale;

                    Size.x -= Time.deltaTime;
                    Size.y -= Time.deltaTime;
                    Size.z -= Time.deltaTime;

                    transform.localScale = Size;
                }
            }
        }

        // Vector3 resize = new Vector3(Mathf.Sin(-Time.time)+1, Mathf.Sin(-Time.time)+1, Mathf.Sin(-Time.time)+1);
        // transform.localScale = resize;
    }
}
