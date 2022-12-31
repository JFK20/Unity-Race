using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise
{

    public static float[,] GenerateNoise(int mapWidth,int mapHeight, int seed, float scale, int octaves, float persitance,float lacunarity,Vector2 offset)
    {
        float[,] noisMap= new float[mapWidth,mapHeight];

        System.Random prng = new System.Random(seed);
        Vector2[] octaveOffsetts= new Vector2[octaves];
        for (int i = 0; i < octaves; i++)
        {
            float offsetX = prng.Next(-10000, 10000) + offset.x;
            float offsetY = prng.Next(-10000, 10000) + offset.y;
            octaveOffsetts[i] = new Vector2(offsetX, offsetY);
        }

        if (!(scale> 0)) 
        {
            scale = 0.0001f;
        }

        float maxNoiseHeight = float.MinValue;
        float minNoiseHeight = float.MaxValue;

        float halfwidth = mapWidth/ 2f;
        float halfheight = mapHeight/ 2f;

        for (int y = 0; y < mapHeight; y++)
        {
            for(int x = 0;x< mapWidth; x++)
            {
                float amplitude = 1;
                float frequency = 1;
                float noiseHeight = 0;

                for (int i = 0;i < octaves; i++)
                {
                    float sampleX = (x - halfwidth) / scale * frequency + octaveOffsetts[i].x;
                    float sampleY = (y - halfheight) / scale * frequency + octaveOffsetts[i].y;

                    float perlinValue = Mathf.PerlinNoise(sampleX, sampleY) * 2 - 1;
                    noiseHeight += perlinValue * amplitude;

                    amplitude *= persitance;
                    frequency*= lacunarity;
                }

                if (noiseHeight > maxNoiseHeight)
                {
                    maxNoiseHeight = noiseHeight;
                }
                else if (noiseHeight < minNoiseHeight)
                {
                    minNoiseHeight = noiseHeight;
                }
                noisMap[x, y] = noiseHeight;
            }
        }
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                noisMap[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, noisMap[x,y]);
            }
        }
        return noisMap;
    }
}
