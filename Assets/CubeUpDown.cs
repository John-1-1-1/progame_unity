using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUpDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private int v = 1;
    void Update() {
        if (transform.position.y < 2 && v == 1) {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else { v = 0; }
        if (transform.position.y > 0 && v == 0) {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        else { v = 1; }
    }
}
