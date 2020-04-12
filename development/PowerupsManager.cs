using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupsManager : MonoBehaviour
{
    private bool doublePoints;
    private bool safeMode;
    private bool powerupActive;
    private float powerupLengthCounter;
    private ScoreManager theScoreManager;
    private PlatformsGenerator thePlatformGenerator;
    private GameManager theGameManager;

    private float normalPointsPerSecond;
    private float spikeRate;
    private PlatformDestroyer[] spikeList;

    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        thePlatformGenerator = FindObjectOfType<PlatformsGenerator>();
        theGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powerupActive)
        {
            powerupLengthCounter -= Time.deltaTime;

            if (theGameManager.powerUpReset)
            {
                powerupLengthCounter = 0;
                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theGameManager.powerUpReset = false;
            }

            if (doublePoints)
            {
                theScoreManager.pointsPerSecond = normalPointsPerSecond * 2f;
                theScoreManager.shouldDouble = true;
            }

            if (safeMode)
            {
                thePlatformGenerator.randomSpikeThreshold = 0f;
            }

            if (powerupLengthCounter <= 0f)
            {
                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theScoreManager.shouldDouble = false;
                thePlatformGenerator.randomSpikeThreshold = spikeRate;
                powerupActive = false;
            }
        }
    }

    public void ActivePowerUp(bool points, bool safe, float time)
    {
        doublePoints = points;
        safeMode = safe;
        powerupLengthCounter = time;

        normalPointsPerSecond = theScoreManager.pointsPerSecond;
        spikeRate = thePlatformGenerator.randomSpikeThreshold;

        if (safeMode)
        {
            spikeList = FindObjectsOfType<PlatformDestroyer>();
            for (int i = 0; i < spikeList.Length; i++)
            {
                if (spikeList[i].gameObject.name.Contains("spikes"))
                {
                    spikeList[i].gameObject.SetActive(false);
                }

            }
        }

        powerupActive = true;
    }
}
