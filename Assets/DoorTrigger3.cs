using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger3 : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    //public GameObject Door;
    public TextTrigger3 tt3;

    //Vector3 newPos = new Vector3(70f, 10f, 0f);

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("The player has opened the door3", gameObject);
            //Door.transform.position = newPos;
            tt3.hasMet3 = true;
        }
    }
}
