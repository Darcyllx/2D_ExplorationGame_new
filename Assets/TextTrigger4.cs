using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger4 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject boatObject;
    public bool hasMet4;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        boatObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            if (hasMet4 == false)
            {
                uiObject.SetActive(true);
                boatObject.SetActive(true);
                Debug.Log("hasMet4 is false");
            }
            else
            {
                uiObject2.SetActive(true);
                Debug.Log("hasMet4 is true");
            }

            StartCoroutine("WaitForSec");
            Debug.Log("Message4 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
}
