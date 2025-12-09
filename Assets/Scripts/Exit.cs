using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public bool collectedAllKeys = false;
    public GameObject winMenu;

    public void Start()
    {
        winMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(collectedAllKeys)
            {
                winMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
    public void restartScene()
    {
        SceneManager.LoadScene(0);
    }

}
