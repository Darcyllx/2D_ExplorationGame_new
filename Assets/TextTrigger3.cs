using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger3 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject appleObject;
    public AudioSource npcSound1;
    public AudioSource npcSound2;
    public AudioSource doorSound;
    public bool hasMet3;

    public GameObject Door;
    Vector3 newPos = new Vector3(73.2f, -16f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        appleObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            if (hasMet3 == false)
            {
                uiObject.SetActive(true);
                appleObject.SetActive(true);
                Debug.Log("hasMet3 is false");
                npcSound1.Play();
            }
            else
            {
                uiObject2.SetActive(true);
                Debug.Log("hasMet3 is true");
                npcSound2.Play();
                Door.transform.position = newPos;
                doorSound.Play();
            }

            StartCoroutine("WaitForSec");
            Debug.Log("Message3 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
}
