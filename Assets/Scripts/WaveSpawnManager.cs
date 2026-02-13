using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] waveConfig;
    public WaveController waveController;

    private int currentWaveIndex = 0;
    private float waveEndTime = 0;

    void Start()
    {
        waveController.changeWave(waveConfig[0]);
    }

    void Update()
    {
        if (waveController.IsCompleted())
        {
            currentWaveIndex++;
            if (currentWaveIndex < waveConfig.Length)
            {
             waveController.changeWave(waveConfig[currentWaveIndex]);                
            }
            else
            {
                Debug.Log("All done");
            }
        }
    }
}