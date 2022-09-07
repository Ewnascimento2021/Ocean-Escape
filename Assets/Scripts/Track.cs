using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "New Track",menuName = "Track")]
public class Track : ScriptableObject
{
    public string songName;

    public List<float> NoteTimeList = new List<float>();

    private string path;


     public void Save()
    {
        path = "Assets/Tracks/" + songName + ".txt";
        var content = JsonUtility.ToJson(this, true);
        File.WriteAllText(path, content);
    }

    public void Load()
    {
        path = "Assets/Tracks/" + songName + ".txt";
        var content = File.ReadAllText(path);
        var p = JsonUtility.FromJson<PlayerJson>(content);
        NoteTimeList = p.NotaTime;
    }
    public void AddNote(float noteTime)
    {
        NoteTimeList.Add(noteTime);
    }

}
