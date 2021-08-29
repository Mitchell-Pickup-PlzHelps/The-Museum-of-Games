using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Controller : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        //Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, player.transform.position.y));
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, -50));
        Vector3 forward = mouseWorld - player.transform.position;
        player.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
    }
}

