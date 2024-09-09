using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Zombie;
     private float time; //Oluþma Zamaný
     private float finishTime=10f; //Bitiþ zamaný

    void Start()
    {
        time = finishTime;
    }

    void Update()
    {
        time -=Time.deltaTime;
        if(time <0)
        {
            Vector3 pos = new Vector3(Random.Range(570f, 381.8f), 5.72998f, Random.Range(320f, 527.5535f));
            time = finishTime;
        }
    }


}
