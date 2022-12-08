//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BirdGenerator : MonoBehaviour
//{
//    public GameObject bird;

//    public float MinSpeed;
//    public float MaxSpeed;
//    public float currentSpeed;

//    public float SpeedMultiplier;

//    public Vector3 spawnPosition;

//    // Start is called before the first frame update
//    void Awake()
//    {
//        currentSpeed = MinSpeed;
//        generateBird();
//    }

//    public void GenerateNextBirdWithGap()
//    {
//        float randomWait = Random.Range(0.6f, 1.2f);
//        Invoke("generateBird", randomWait);
//    }



//    // Update is called once per frame
//    void Update()
//    {
//        if (currentSpeed < MaxSpeed)
//        {
//            currentSpeed += SpeedMultiplier;
//        }
//    }
//}
