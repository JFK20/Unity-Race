using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;

public class CreateTrack : MonoBehaviour
{
    public int mapWidth = 1;
    public int mapHeight = 20;
    public float noiseScale = 0.5f;

    private int ocatives = 5;
    public float persistance = 6;
    public float lacunarity = 0.1f;

    public int seed = 55;
    public Vector2 offset = new Vector2(0,0);

    public float[,] Map;

    public GameObject[] tracks;

    TextMeshProUGUI test;

    [SerializeField]
    GameObject straight;

    [SerializeField]
    GameObject curve;

    [SerializeField]
    GameObject Vater;

    [SerializeField]
    GameObject Car;
    [SerializeField] 
    private TextMeshProUGUI result;
    public void trackstats()
    {
        Map = Noise.GenerateNoise(mapWidth, mapHeight, seed, noiseScale, ocatives, persistance, lacunarity, offset);
    }

    private void Start()
    {
        tracks = new GameObject[100];
        trackstats();
        curve.transform.Rotate(0, 0, 90);
        test = GetComponent<TextMeshProUGUI>();
        for (int i = 0;i < mapHeight;i++)
        {
            test.text += " "  + Map[0,i];
        }
        StartCoroutine(gesamt());
        result.GetComponent<RaceCalc>().Calculate(Map,mapHeight);
    }

    private void Update()
    {
            //print(Car.transform.rotation.eulerAngles.z);
    }

    /*public void spawn()
    {
        for (int i = 0; i < mapHeight; i++)
        {
            if (Map[0, i] > 0.5)
            {
                var build = Instantiate(straight, new Vector3(-280, 0, 0), Quaternion.identity);
                build.transform.SetParent(Vater.transform, false);
                build.name = "" + i;
                StartCoroutine(Waitcheck(15,i));
                build.transform.Translate(0,100,0);
                StartCoroutine(Waitcheck(10, i+100));
            }
        }
    }*/

    IEnumerator gesamt()
    {
        for (int i = 0; i < mapHeight; i++)
        {
            GameObject build = spawn(i);
            //yield return new WaitForSeconds(2);
            bewege(build);
            tracks[i] = build;
            yield return new WaitForSeconds(0.5f);
            for (int j = 0; j < mapHeight; j++)
            {
                if (tracks[j] != null)
                {
                    bewege(tracks[j]);
                }
            }
        }
    }

    public GameObject spawn(int i)
    {
        GameObject build = null;
        if (Map[0,i] > 0.15)
        {
            build = Instantiate(straight, new Vector3(-280, -200, 0), Quaternion.identity);
            build.transform.SetParent(Vater.transform, false);
            build.name = "" + i;
            build.tag = "Straight";
            build.transform.SetAsFirstSibling();
            if (Car.transform.eulerAngles.z >= 200 && !(Car.transform.eulerAngles.z < 180))
            {
                Car.transform.Rotate(0, 0, -20);
            }



        }
        if (Map[0,i] <= 0.15)
        {
            build = Instantiate(curve, new Vector3(-280, -200, 0), Quaternion.identity);
            build.transform.SetParent(Vater.transform, false);
            build.name = "" + i;
            build.tag = "Curve";
            build.transform.SetAsFirstSibling();
            if (Car.transform.eulerAngles.z >= 180 && Car.transform.eulerAngles.z < 200)
            {
                Car.transform.Rotate(0, 0, 20);
            }
        }
        return build;
    }

    public void bewege(GameObject build)
    {
        build.transform.Translate(0, 100, 0);
    }

    public int getHeight()
    {
        return mapHeight;
    }

}
