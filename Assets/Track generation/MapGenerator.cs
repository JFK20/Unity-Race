using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public bool autoupdate;

    public int ocatives;
    public float persistance;
    public float lacunarity;

    public int seed;
    public Vector2 offset;

    public void GenerateMap()
    {
        float[,] noiseMap = Noise.GenerateNoise(mapWidth,mapHeight,seed,noiseScale,ocatives,persistance,lacunarity,offset);

        MapDisplay display = FindObjectOfType<MapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }

    private void OnValidate()
    {
        if (mapWidth < 1)
        {
            mapWidth= 1;
        }
        if (mapHeight < 1)
        {
            mapHeight= 1;
        }
        if (ocatives < 0)
        {
            ocatives= 0;
        }
    }

}
