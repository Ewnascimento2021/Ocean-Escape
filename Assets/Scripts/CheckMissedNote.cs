using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMissedNote : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Heart"))
        {
            PauseController.Instance.Congratulations();
        }
        else
        {
            GameManager.Instance.Miss();
            Destroy(other.gameObject);
        }

        
    }
}
