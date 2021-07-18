using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    float hassasiyet = 5f;
    float yumusaklik = 2f;

    Vector2 gecisPos;
    Vector2 cameraPos;

    GameObject oyuncu;

    public OyunKontrol oyunK;

    // Start is called before the first frame update
    void Start()
    {
        oyuncu = transform.parent.gameObject;
        cameraPos.y = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        if(oyunK.oyunAktif)
        {
            Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            farePos = Vector2.Scale(farePos, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
            gecisPos.x = Mathf.Lerp(gecisPos.x, farePos.x, 1f / yumusaklik);
            gecisPos.y = Mathf.Lerp(gecisPos.y, farePos.y, 1f / yumusaklik);
            cameraPos += gecisPos;

            transform.localRotation = Quaternion.AngleAxis(-cameraPos.y, Vector3.right);
            oyuncu.transform.localRotation = Quaternion.AngleAxis(cameraPos.x, oyuncu.transform.up);
        }
        
    }
}
