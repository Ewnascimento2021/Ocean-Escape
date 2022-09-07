using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNotes : MonoBehaviour
{
    public bool isSomeNoteInside;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isSomeNoteInside = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isSomeNoteInside = false;
    }
}
