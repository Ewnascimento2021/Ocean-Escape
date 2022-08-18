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
    public PlayerJson json;

    public float speed;

    [SerializeField]
    private float delay;

    [SerializeField]
    private GameObject Nota;

    private List<float> ItalianAfternoon = new List<float>();

    [SerializeField]
    private AudioSource song;

    void Start()
    {
        json = new PlayerJson();

        json.Load();

        ItalianAfternoon = json.NotaTime;

        for(int i = 0; i < ItalianAfternoon.Count; i++)
        {
            SpawnNote(ItalianAfternoon[i]);
        }
       
        song.Play();
    }

    private void SpawnNote(float time)
    {
        float distance = speed * time * 50 + delay;
        Vector2 pos = new Vector2(distance + transform.position.x, transform.position.y);
        Instantiate(Nota, pos, transform.rotation);
    }
}
