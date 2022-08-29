using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class CoinControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Coinn;
    public Text scoreUI;
    public int score;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreUI.text = score.ToString();

        }
    }
}
