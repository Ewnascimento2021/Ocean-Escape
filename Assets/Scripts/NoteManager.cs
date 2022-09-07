using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{

    static NoteManager instance;
    public static NoteManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<NoteManager>();
            return instance;
        }
    }
    public float speed;
    public PlayerJson json = new PlayerJson();

    [SerializeField]
    private string songName;
    [SerializeField]
    private float delay;
    [SerializeField]
    private GameObject Nota;

    private List<float> trackNoteList = new List<float>();

  
    public AudioSource song;

    void Start()
    {
        json.songName = songName;
        json.StartTrack();
        json.Load();

        trackNoteList = json.NotaTime;

        for(int i = 0; i < trackNoteList.Count; i++)
        {
            SpawnNote(trackNoteList[i],i);
        }
       
        song.Play();
    }

    private void SpawnNote(float time, int count)
    {
        float distance = speed * time * 50 + delay;
        Vector2 pos = new Vector2(distance + transform.position.x, transform.position.y);
        GameObject novaNota = (Instantiate(Nota, pos, transform.rotation));
#if UNITY_EDITOR
        novaNota.name = count.ToString() + " - NOTA";
#endif
    }
}
