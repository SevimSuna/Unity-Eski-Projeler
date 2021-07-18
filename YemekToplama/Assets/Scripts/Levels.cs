using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HomePageOn()
    {
        SceneManager.LoadScene("Giris");
    }
    public void FirstLevel()
    {
        SceneManager.LoadSceneAsync("IlkSeviyeGiris");
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene("IkinciSeviyeGiris");
    }
    public void ThirdLevel()
    {
        SceneManager.LoadScene("UcuncuSeviyeGiris");
    }

}
