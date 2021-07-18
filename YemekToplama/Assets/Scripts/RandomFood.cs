using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomFood : MonoBehaviour
{
    public GameObject[] cisim;
    public Vector2 deger;
    public Text puan, can;
    public int skor, index;
    void Start()
    {
        SpawnWaves();
    }

    // Update is called once per frame
    void Update()
    {
        puan.text = skor.ToString();
    }
    public void SpawnWaves()
    {
        index = Random.Range(0, 11);
        Vector3 SpawnPosition = new Vector3(Random.Range(-deger.x, deger.x), Random.Range(deger.y, 10f), 0);
        Quaternion spawnRotate = Quaternion.identity;
        Instantiate(cisim[index], SpawnPosition, spawnRotate);
    }
    public void SpawnWaves2(int indexWave)
    {
        index = indexWave;
        Vector3 SpawnPosition = new Vector3(Random.Range(-deger.x, deger.x), Random.Range(deger.y, 10f), 0);
        Quaternion spawnRotate = Quaternion.identity;
        Instantiate(cisim[index], SpawnPosition, spawnRotate);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hambuger" || collision.gameObject.tag == "Pizza" || collision.gameObject.tag == "Waffle" || collision.gameObject.tag == "Cake")
        {
            Destroy(collision.gameObject);
            skor += 2;
            SpawnWaves();
        }
        if (collision.gameObject.tag == "Apple" || collision.gameObject.tag == "Banana" || collision.gameObject.tag == "Grape" || collision.gameObject.tag == "Cherry")
        {
            Destroy(collision.gameObject);
            skor ++;
            SpawnWaves();
        }
        if (collision.gameObject.tag == "Watermelon" || collision.gameObject.tag == "Orange" || collision.gameObject.tag == "Carrot")
        {
            Destroy(collision.gameObject);
            skor += 3;
            SpawnWaves();
        }
    }
}
