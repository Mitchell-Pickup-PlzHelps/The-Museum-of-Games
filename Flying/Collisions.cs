using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collisions : MonoBehaviour
{
    public GameObject hoop;


    void Start()
    {
        //Set the tag of this GameObject to Player
        // gameObject.tag = "plane";
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collission detercted");
        //Check to see if the tag on the collider is equal to Enemy
       // if (other.tag == "Goal")
       // {
            Debug.Log("Triggered by goal");
            hoop.SetActive(false);
        score.scoreValue += 1;
       // }
    }
}
