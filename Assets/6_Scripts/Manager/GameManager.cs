using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform Player {  get; private set; }

    [SerializeField] private string playerTag = "Player";
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float time = 5f;

    private int coinCount = 0;
    private int score = 0;
    private int increaseScore = 10;

    private bool gameOver = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Player = GameObject.FindGameObjectWithTag(playerTag).transform;
    }

    private void Start()
    {
        UpdateCoinUI();
        StartCoroutine(ScoreIncreased());
    }

    public void AddCoin(int amount)
    {
        coinCount += amount;
        UpdateCoinUI();
    }

    private void UpdateCoinUI()
    {
        coinText.text = coinCount.ToString();
    }

    private IEnumerator ScoreIncreased()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(time);
            score += increaseScore;
            UpdateScoreUI();
        }
        
    }

    private void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOver = true;
        StopCoroutine(ScoreIncreased());
    }


}
