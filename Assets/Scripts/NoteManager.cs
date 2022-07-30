using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public PlayerJson json;

    private float initialTime;

    private int contador;

    private float elapsedTime;

    [SerializeField]
    private float speed;

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

        foreach (int i in ItalianAfternoon)
        {
            SpawnNote(ItalianAfternoon[i]);
        }
        song.Play();

        initialTime = Time.time;
    }

    private void SpawnNote(float time)
    {
        float distance = speed * time * 50  ;
        Vector2 pos = new Vector2(distance, transform.position.y);
        Instantiate(Nota, pos, transform.rotation);
        Debug.Log(pos);
    }

    private void FixedUpdate()
    {
        contador ++;
        elapsedTime = Time.time - initialTime;
        if (elapsedTime >= 1)
        {
            Debug.Log(contador);
            initialTime = Time.time;
            contador = 0;
        }
    }
}
