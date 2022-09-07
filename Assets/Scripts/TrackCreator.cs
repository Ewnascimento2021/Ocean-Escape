using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCreator : MonoBehaviour
{
    public PlayerJson json = new PlayerJson();
    [SerializeField]
    private string songName;
    private float initialTime;
    private float elapsedTime;
    void Start()
    {
        json.songName = songName;
        json.StartTrack();
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