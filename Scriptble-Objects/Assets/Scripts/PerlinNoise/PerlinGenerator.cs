using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinGenerator : MonoBehaviour
{
    public float StartCoord = -10;
    public float EndCoord = 10;
    public float Step = 0.5f;
    public GameObject TemplateObject;

    void Start()
    {
        for(float x = StartCoord; x < EndCoord; x+= Step)
        {
            for (float y = StartCoord; y < EndCoord; y += Step)
            {
                var position = new Vector3(x, y, 0);  
                var spawnObj = Instantiate(TemplateObject, position, Quaternion.identity); 
                var spriteRenderer  = spawnObj.GetComponent<SpriteRenderer>();

                var perlinNoise = Mathf.PerlinNoise(x + 10, y + 10);
                spriteRenderer.color = spriteRenderer.color * perlinNoise;

            }
        }
    }

}
