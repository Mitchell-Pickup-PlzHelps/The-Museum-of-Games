using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int points;
    public EnemyType myType;
    public GameObject stars;
    public AudioSource audioSource;
    public void Setup()
    {
        int rnd = Random.Range(0, 10);
        if (rnd < 3) myType = EnemyType.EASY;
        if (rnd >= 3 && rnd < 7) myType = EnemyType.MEDIUM;
        if (rnd >= 7) myType = EnemyType.HARD;
        switch(myType)
        {
            case EnemyType.EASY:
                transform.localScale = Vector3.one * 1.5f;
                GetComponent<Renderer>().material.color = Color.green;
                points = 5;
                break;
            case EnemyType.MEDIUM:
                transform.localScale = Vector3.one * 1f;
                GetComponent<Renderer>().material.color = Color.yellow;
                points = 10;
                break;
            case EnemyType.HARD:
                transform.localScale = Vector3.one * 0.5f;
                GetComponent<Renderer>().material.color = Color.red;
                points = 15;
                break;
        }
    }

    public void TakeDamage(int _damage)
    {
        Instantiate(audioSource, transform.position, transform.rotation);
        Instantiate(stars, transform.position, transform.rotation);
        Debug.Log(health);
        audioSource.Play();
        score.scoreValue += points;
           
            //Destroy(this.gameObject, 5f);
            Destroy(this.gameObject);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
            TakeDamage(0);
    }
}
