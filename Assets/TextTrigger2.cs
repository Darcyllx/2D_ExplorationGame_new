using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger2 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject keyObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        keyObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            keyObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("Message is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
