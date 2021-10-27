using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextTrigger5 : MonoBehaviour
{
    public GameObject uiObject;
    public AudioSource npcSound1;
    //public GameObject boatObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        //boatObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            //boatObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Debug.Log("Message is shown");
            npcSound1.Play();
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
