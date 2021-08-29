using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType { EASY, MEDIUM, HARD}
public class Enemy_Manager : MonoBehaviour
{
    public float speed = 1f;
    public GameObject Target;
    public Vector3 minPos;
    public Vector3 maxPos;
    private void Start()
    {
        InvokeRepeating("Spawn", 0, speed);
    }
    void Spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y), Random.Range(minPos.z, maxPos.z));
        GameObject instantiatedProjectile = Instantiate(Target,spawnPos,transform.rotation) as GameObject;
        instantiatedProjectile.GetComponentInChildren<Enemy>().Setup();
        Destroy(instantiatedProjectile, 5);
 
    }
}
