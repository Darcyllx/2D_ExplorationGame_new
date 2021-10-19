using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class TextTriggerAfter1 : MonoBehaviour
{
    public GameObject uiObject;
    

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("MessageAfter1 is not shown yet but collide");
        if (collision.CompareTag("Player")&& GameObject.Find("fish").GetComponent<DoorTrigger>().hasMet1 == true)
        {
            uiObject.SetActive(true);

            StartCoroutine("WaitForSec");
            Debug.Log("MessageAfter1 is shown");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);   
    }
}
*/
