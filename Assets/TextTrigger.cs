using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    //public GameObject textbox;
    public GameObject fishObject;
    public AudioSource npcSound1;
    public AudioSource npcSound2;
    public AudioSource doorSound;

    public bool hasMet1;

    public GameObject Door;
    Vector3 newPos = new Vector3(19f, 1.180f, 0f);
    //public GameObject squareObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        //textbox.SetActive(false);
        fishObject.SetActive(false);
        //hasMet1 = false;
        //squareObject.SetActive(false);

    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.tag == "Player")
        {
            if(hasMet1 == false)
            {
                uiObject.SetActive(true);
                //textbox.SetActive(true);
                fishObject.SetActive(true);
                Debug.Log("hasMet1 is false");
                npcSound1.Play();
            }
            else
            {
                uiObject2.SetActive(true);
                //textbox.SetActive(true);
                Debug.Log("hasMet1 is true");
                npcSound2.Play();
                Door.transform.position = newPos;
                doorSound.Play();

            }

            //fishObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("Message1 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        //textbox.SetActive(false);
        //Destroy(uiObject);
        //Destroy(uiObject2);

        //Destroy(gameObject);
        //hasMet1 = false;
    }
}
