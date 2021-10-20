using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRandom : MonoBehaviour
{
    public Transform[] points;
    public float InvokeRate = 1.0f;
    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {
        PickPoints();
    }

    // Updatse is called once per frame
    void PickPoints()
    {
        int indexNumber = Random.Range(0, points.Length);
        Key.transform.position = points[indexNumber].position;
        //Instantiate(Key, points[indexNumber].position, Key.transform.rotation);
    }
}
