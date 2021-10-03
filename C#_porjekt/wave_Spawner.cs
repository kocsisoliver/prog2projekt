using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public static int EnemiesAlive = 0;

    public static Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    public float countdown = 2f;

    //public float timeBetweenEnemies = 0.5f;

    public Text waveCountdownText;
    public Text wavesText;

    private int waveIndex = 0;

    private void Update()
    {
        if (EnemiesAlive > 0)
        {
            return;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}", countdown);

        wavesText.text = (waveIndex + 1) + "/" + waves.Length;
    }

}





