using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerControl thePlayer;
    private Vector3 playerStartPoint;

    private PlatformDestroyer[] platformsList;

    private ScoreManager theScoreManager;


    public DeathMenu theDeathScreen;
    public bool powerUpReset;

    // Start is called before the first frame update
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);

        theDeathScreen.gameObject.SetActive(true);
        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theDeathScreen.gameObject.SetActive(false);

        platformsList = FindObjectsOfType<PlatformDestroyer>();
        for (int i = 0; i < platformsList.Length; i++)
        {
            platformsList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
        theScoreManager.pointsPerSecond = 5;

        powerUpReset = true;

    }
    /*public IEnumerator RestartGameCo ()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platformsList = FindObjectsOfType<PlatformDestroyer>();
        for(int i = 0;i <platformsList.Length; i++)
        {
            platformsList[i].gameObject.SetActive(false);

        }
        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    } */
}
