 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainPoints : MonoBehaviour
{
    public GameObject point;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by goal");
        point.SetActive(false);
        pointslose.scoreValue += 10;
    }
}
