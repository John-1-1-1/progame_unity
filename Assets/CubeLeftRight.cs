using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLeftRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private int v = 1;
    void Update()
    {
        if (transform.position.x < 10 && v == 1) {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else { v = 0; }
        if (transform.position.x > -10 && v == 0) {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else { v = 1; }
    }
}
