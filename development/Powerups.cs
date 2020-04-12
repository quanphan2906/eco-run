using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public bool doublePoints;
    public bool safeMode;
    public float powerupLength;
    private PowerupsManager thePowerupsManager;
    public Sprite[] powerupSprites;

    //CHOOSE WHICH POWERUPS TO RENDER
    void Awake()
    {
        int powerupSelector = Random.Range(0, 2);

        switch (powerupSelector)
        {
            case 0:
                doublePoints = true;
                break;
            case 1:
                safeMode = true;
                break;
        }

        GetComponent<SpriteRenderer>().sprite = powerupSprites[powerupSelector];
    }

    // Start is called before the first frame update
    void Start()
    {
        thePowerupsManager = FindObjectOfType<PowerupsManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            thePowerupsManager.ActivePowerUp(doublePoints, safeMode, powerupLength);
        }
        gameObject.SetActive(false);
    }
}
