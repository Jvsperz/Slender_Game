using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class KeyCollection : MonoBehaviour
{
    private int Key = 0;

    public TextMeshProUGUI keyText;
    public GameObject goToExit;
    public Exit exit;

    public void Start()
    {
        goToExit.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Key")
        {
            Key++;
            keyText.text = "Keys: " + Key.ToString();
            Debug.Log(Key);
            Destroy(other.gameObject);
        }

        if (Key == 19)
        {
            exit.collectedAllKeys = true;

            StartCoroutine(waitToTurnOFf());
        }
    }

    IEnumerator waitToTurnOFf()
    {
        goToExit.SetActive(true);

        yield return new WaitForSeconds(4);

        goToExit.SetActive(false);
    }

}
