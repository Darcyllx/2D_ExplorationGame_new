using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger4 : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject Door;
    public TextTrigger4 tt4;

    Vector3 newPos = new Vector3(70f, 10f, 0f);

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
            Debug.Log("The player has opened the door4", gameObject);
            Door.transform.position = newPos;
            tt4.hasMet4 = true;
        }
    }
}
