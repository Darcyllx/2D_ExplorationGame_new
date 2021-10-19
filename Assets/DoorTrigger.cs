using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject Door;
    public TextTrigger tt;

    Vector3 newPos = new Vector3(19f, 1.180f, 0f);
    
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
            Debug.Log("The player has got the fish and opened the door", gameObject);
            Door.transform.position = newPos;
            tt.hasMet1 = true;
            //Debug.Log("hasMet1 is true");
        }
    }
}
