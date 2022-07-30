using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCreator : MonoBehaviour
{
    public PlayerJson json;

    private float initialTime;

    private float elapsedTime;

    void Start()
    {
        json = new PlayerJson();

        json.Save();

        //json.Load();

        initialTime = Time.time;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            elapsedTime = Time.time - initialTime;

            json.AddNote (elapsedTime);

            json.Save();

           //json.Load();
            
        }
    }
  
}
