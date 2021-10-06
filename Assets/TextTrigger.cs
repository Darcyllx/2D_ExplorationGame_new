using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject fishObject;
  

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        fishObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            fishObject.SetActive(true);
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
