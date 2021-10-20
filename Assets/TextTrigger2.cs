using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger2 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject keyObject;
    public bool hasMet2;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        keyObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            if (hasMet2 == false)
            {
                uiObject.SetActive(true);
                keyObject.SetActive(true);
                Debug.Log("hasMet2 is false");
            }
            else
            {
                uiObject2.SetActive(true);
                Debug.Log("hasMet2 is true");
            }

            //fishObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("Message1 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
}
