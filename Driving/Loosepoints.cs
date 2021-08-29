using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loosepoints : MonoBehaviour
{
    public GameObject obs;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collission detercted");
        pointslose.scoreValue -= 1;
    }
}
