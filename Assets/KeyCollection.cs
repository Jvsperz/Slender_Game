using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class KeyCollection : MonoBehaviour
{
    private int Key = 0;

    public TextMeshProUGUI keyText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Key")
        {
            Key++;
            keyText.text = "Keys: " + Key.ToString();
            Debug.Log(Key);
            Destroy(other.gameObject);
        }
    }

}
