using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject Door;
    public TextTrigger2 tt2;

    Vector3 newPos = new Vector3(45.1f, 1.181f, 0f);

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
            Debug.Log("The player has opened the door2", gameObject);
            Door.transform.position = newPos;
            tt2.hasMet2 = true;
        }
    }
}

