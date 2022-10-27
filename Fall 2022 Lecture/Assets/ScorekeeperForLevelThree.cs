using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScorekeeperForLevelThree : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] Text sceneText;
    const int DEFAULT_POINTS = 1;
    const int SCORE_TO_ADVANCE = 10;
    int level;
    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        scoreText.text = "Score: " + score;
        sceneText.text = "Starring Level 3. Level " + (level + 1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Score: " + score;
        if (score >= SCORE_TO_ADVANCE)
        {
            //move to the next level
            AdvanceLevel();
        }
    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AdvanceLevel()
    {
        SceneManager.LoadScene(level + 1);
    }
}
