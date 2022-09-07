using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TrackCreator2 : MonoBehaviour
{
    [SerializeField]
    private string trackSongName;

    public Track trackData;

    private float initialTime;

    private float elapsedTime;

    private void Start()
    {
        trackData.songName = trackSongName;

        trackData.Save();

        initialTime = Time.time;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            elapsedTime = Time.time - initialTime;

            trackData.AddNote(elapsedTime);

            trackData.Save();

        }
    }
}
