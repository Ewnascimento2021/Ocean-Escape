using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class PlayerJson
{
    public string songName;

    public List<float> NotaTime = new List<float>();

    public string path = "Assets/Player.txt";

    public void Save()
    {
        var content = JsonUtility.ToJson(this, true);
        File.WriteAllText(path, content);
    }

    public void Load()
    {
        var content = File.ReadAllText(path);
        var p = JsonUtility.FromJson<PlayerJson>(content);
        NotaTime = p.NotaTime;
    }
    public void AddNote(float noteTime)
    {
        NotaTime.Add(noteTime);
    }
}