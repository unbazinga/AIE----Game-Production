//using UnityEngine;

//public class SpikeGenerator : MonoBehaviour
//{

//    public GameObject spike;

//    public float MinSpeed;
//    public float MaxSpeed;
//    public float currentSpeed;

//    public float SpeedMultiplier;
//    // Start is called before the first frame update
//    void Awake()
//    {
//        currentSpeed = Random.Range(MinSpeed, MaxSpeed);
//        generateSpike();
//    }

//    public void GenerateNextSpikeWithGap()
//    {        
//        if(Random.Range(0,5) > 3)
//        {
//            for(int i = 0; i < 3; i++)
//            {
//                Debug.Log("Double trouble? nah, Triple Trouble");
//                Invoke("generateSpike", Random.Range(0.1f, 0.5f));
//            }
//        } else
//        {
//            Invoke("generateSpike", Random.Range(0.4f, 1.2f));
//        }
//    }



//    // Update is called once per frame
//    void Update()
//    {
//        if(currentSpeed < MaxSpeed)
//        {
//            currentSpeed += SpeedMultiplier;
//        }
//    }
//}
