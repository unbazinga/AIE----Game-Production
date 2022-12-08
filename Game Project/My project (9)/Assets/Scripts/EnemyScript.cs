//using System.Collections;
//using UnityEngine;

//public class EnemyScript : MonoBehaviour
//{
//    public SpikeGenerator spikeGenerator;
//    public BirdGenerator birdGenerator;
//    public PlayerScript playerScript;
//    bool flipper;
//    public float curTimer;
//    public float maxTimer;
//    // Update is called once per frame


//    void Update()
//    {
//        if (curTimer > maxTimer)
//        {
//            curTimer = 0;
//            birdGenerator.GenerateNextBirdWithGap();
//            spikeGenerator.GenerateNextSpikeWithGap();
//        }
//        curTimer += 1 * Time.deltaTime;

//        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if(this.gameObject.CompareTag("Bird")) {
//            if (collision.gameObject.CompareTag("Finish"))
//            {
//                Destroy(this.gameObject);
//            }
//        }
//        else if(this.gameObject.CompareTag("Spike"))
//        {
//            if (collision.gameObject.CompareTag("Finish"))
//            {
//                Destroy(this.gameObject);
//            }
//        }

//    }

//}
