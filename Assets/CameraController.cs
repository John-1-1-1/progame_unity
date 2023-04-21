using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;
    
    // Use this for initialization
    void Start () {
        offset = player.transform.position - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update () {
gameObject.transform.position = new Vector3 (

(player.transform.position.x - offset.x),

4f*player.transform.position.y - offset.y,
(player.transform.position.z - offset.z));

}
 
}
