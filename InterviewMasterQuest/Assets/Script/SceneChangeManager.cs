using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    /// <summary>
    /// Opening��Main
    /// </summary>
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    /// <summary>
    /// Main��Select
    /// </summary>
    public void LoadSelectScene()
    {
        SceneManager.LoadScene("SelectScene");
    }

    /// <summary>
    /// Select��Question
    /// </summary>
    public void LoadQuestionScene()
    {
        SceneManager.LoadScene("QuestionScene");
    }

    /// <summary>
    /// Question��Result
    /// </summary>
    public void LoadResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }

    /// <summary>
    /// Main��Tutorial
    /// </summary>
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    /// <summary>
    /// Main��Ranking
    /// </summary>
    public void LoadRankingScene()
    {
        SceneManager.LoadScene("RankingScene");
    }

    /// <summary>
    /// Main��ResultList
    /// </summary>
    public void LoadResultListScene()
    {
        SceneManager.LoadScene("ResultListScene");
    }

    /// <summary>
    /// Main��Ranking
    /// </summary>
    public void LoadAAAScene()
    {
        SceneManager.LoadScene("Scene");
    }
}
