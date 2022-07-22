using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    private GameObject[] notesArray = new GameObject[5];
    Queue<GameObject> notesQueue = new Queue<GameObject>();

    private void Update()
    {
        if (Input.GetButton("Touch"))
        {
            if (notesQueue.Peek().gameObject.GetComponent<Note>().noteEnabled)
            {
                notesQueue.Dequeue();

                Debug.Log("acertou");
            }
        }
        else
        {
            Debug.Log("Errou");

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Note>().noteEnabled = true;
        notesQueue.Enqueue(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<Note>().noteEnabled = false;

       // notesQueue.Dequeue();
    }
}
