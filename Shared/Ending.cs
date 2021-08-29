using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public string levelName;
    public GameObject end;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by goal");
        end.SetActive(false);
        SceneManager.LoadScene(levelName);
    }
}
