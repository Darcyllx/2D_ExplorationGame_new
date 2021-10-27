using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger4 : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject boatObject;
    public AudioSource npcSound1;
    public AudioSource npcSound2;
    public bool hasMet4;

    public GameObject Door;
    Vector3 newPos = new Vector3(70f, 10f, 0f);
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
                npcSound1.Play();
            }
            else
            {
                uiObject2.SetActive(true);
                Debug.Log("hasMet4 is true");
                npcSound2.Play();
                Door.transform.position = newPos;
            }

            StartCoroutine("WaitForSec");
            Debug.Log("Message4 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
}
