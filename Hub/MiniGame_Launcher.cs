using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MiniGame_Launcher : MonoBehaviour
{
    public GameObject popupText;
    public string levelName;

    private void Start()
    {
        popupText.SetActive(false);
        if (GetComponent<MeshRenderer>() != null)
            GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        popupText.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadLevel();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        popupText.SetActive(false);
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }
    
}
