using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject fishObject;
    public bool hasMet1;
    //public GameObject squareObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
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
                fishObject.SetActive(true);
                Debug.Log("hasMet1 is false");
            }
            else
            {
                uiObject2.SetActive(true);
                Debug.Log("hasMet1 is true");
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
        //Destroy(uiObject);
        //Destroy(uiObject2);

        //Destroy(gameObject);
        //hasMet1 = false;
    }
}
