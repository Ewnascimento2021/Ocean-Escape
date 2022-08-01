using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCreator : MonoBehaviour
{
    public PlayerJson json;

    [SerializeField]
    private string trackSongName;

    private float initialTime;

    private float elapsedTime;

    void Start()
    {
        json = new PlayerJson();

        json.songName = trackSongName;

        json.Save();

        initialTime = Time.time;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            elapsedTime = Time.time - initialTime;

            json.AddNote (elapsedTime);

            json.Save();
            
        }
    }
  
}
