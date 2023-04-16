using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SocreUi : MonoBehaviour
{
    public TextMeshProUGUI score;
    public GameObject win;
    public GameObject lose;
    public TextMeshProUGUI timer;
    public float time=0f;
    public float startingtime = 10f;
    private int scorenum;
    public bool wingame;

    // Start is called before the first frame update
    void Start()
    {
        scorenum = 0;
        score.text = "Score:" + scorenum;
        timer.text = "Time:" + time;
        time = startingtime;
        win = GameObject.FindGameObjectWithTag("Win");
        lose = GameObject.FindGameObjectWithTag("Lose");
        win.SetActive(false);
        lose.SetActive(false);
        wingame= false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("meat"))
        {
            scorenum += 1;

        }

    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scorenum;
        timer.text = "Time:" + time.ToString("0");
        time-=1* Time.deltaTime;

        if (time <=0) 
        { 
            time = 0;
        }     
           
        if (scorenum >= 15f&&time>=0)
        {
            win.SetActive(true);
            wingame= true;
        }

        if(time==0&&wingame==false)
        {
            lose.SetActive(true);
        }
    }
}
