using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger2 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject keyObject;
    public AudioSource npcSound1;
    public AudioSource npcSound2;

    public bool hasMet2;

    public GameObject Door;
    Vector3 newPos = new Vector3(45.1f, 1.181f, 0f);
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
                npcSound1.Play();
                Debug.Log("hasMet2 is false");
            }
            else
            {
                uiObject2.SetActive(true);
                npcSound2.Play();
                Debug.Log("hasMet2 is true");
                Door.transform.position = newPos;
            }

            //fishObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("Message2 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
}
