using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public bool pnl;
    public GameObject Panel;
    public Text question;
    public Text answer1, answer2, result;
    int sayi1, sayi2, trueAnswer, whichButton;
    //public Button button1;
    //public Button button2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "soru")
        {
            Destroy(c.gameObject);
            pnl = !pnl;
        }
        if(pnl)
        {
            Panel.SetActive(true);
            sayi1 = Random.Range(1, 11);
            sayi2 = Random.Range(1, 11);
            whichButton = Random.Range(1, 3);
            trueAnswer = sayi1 * sayi2;
            question.text = sayi1 + "x" + sayi2 + "= ?";
            if(whichButton == 1)
            {
                answer1.text = trueAnswer.ToString();
                answer2.text = (trueAnswer + sayi2).ToString();
            }
            else
            {
                answer2.text = trueAnswer.ToString();
                answer1.text = (trueAnswer + sayi1).ToString();
            }
            Time.timeScale = 0;
        }
        if(!pnl)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }

    }
    public void AnswerFirstButton()
    {
        if(answer1.text == trueAnswer.ToString())
        {
            pnl = false;
            Panel.SetActive(false);
            Time.timeScale = 1;
            result.text = "Doðru";
        }
        else if(answer1.text != trueAnswer.ToString())
        {
            pnl = false;
            Panel.SetActive(false);
            Time.timeScale = 1;
            result.text = "Yanlýþ";
        }
    }
    public void AnswerSecondButton()
    {
        if (answer2.text == trueAnswer.ToString())
        {
            pnl = false;
            Panel.SetActive(false);
            Time.timeScale = 1;
            result.text = "Doðru";
        }
        else if (answer2.text != trueAnswer.ToString())
        {
            pnl = false;
            Panel.SetActive(false);
            Time.timeScale = 1;
            result.text = "Yanlýþ";
        }
    }
}
