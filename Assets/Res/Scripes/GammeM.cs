using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class GammeM : MonoBehaviour
{
    public GameObject main;
    public GameObject tut;
    public GameObject score;
    public GameObject bird;
    public bool isGameready=false;
    public bool isGameStart = false;
    public Text ScoreText;
    public Text nowScoreText;
    public Text bestScoreText;
    public GameObject NewScore;
    public GameObject over;
    public Image Medal;
    public List<Sprite> medals;
    public void PlayBtnClick()
    {
        Tools.Ins.HideUI(main);
        Tools.Ins.ShowUI(tut);
        Tools.Ins.ShowUI(score);
        bird.GetComponent<FlappyBird>().ChangeState(true);
        isGameready = true;
    }
    private void Update()
    {
        if (!isGameready) return;
        if (isGameStart) return;
        if (Input.GetMouseButtonDown(0))
        {
            Tools.Ins.HideUI(tut);
            
            bird.GetComponent<FlappyBird>().Fly();
            bird.GetComponent<FlappyBird>().ChangeState(true,true);
            isGameStart = true;

        }
        
    }

    public void GameOver()
    {
        isGameready = false;
        isGameStart = false;
        GameObject.Find("ZhuziController").GetComponent<ZhuziController>().StopMove();
        GameObject.Find("bgs").GetComponent<BgController>().isMove = false;
        GameObject.Find("Lands").GetComponent<BgController>().isMove = false;
        Tools.Ins.ShowUI(over);
 
        //拿到分数
        int score = int.Parse(ScoreText.text);
        if (score >= 50)
        {
            Medal.sprite = medals[3];
        }else if (score >= 30)
        {
            Medal.sprite = medals[2];
        }else if (score >= 20)
        {
            Medal.sprite = medals[1];
        }else if (score >= 10)
        {
            Medal.sprite = medals[0];
        }
        else
        {
            Medal.gameObject.SetActive(false);
        }
        
            

        if(PlayerPrefs.GetInt("bestScore")< score)
        { 
            PlayerPrefs.SetInt("bestScore", score);
            NewScore.SetActive(true);
        }
        nowScoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();
        
    }
    public void GetScore()
    {
        if (!isGameStart) return;
        ScoreText.text = (int.Parse(ScoreText.text) + 1).ToString();
    }
    /// <summary>
    /// 重新开始
    /// </summary>
    public void ReStart()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    
}
