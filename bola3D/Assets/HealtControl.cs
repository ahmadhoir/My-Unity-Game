using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int healt;
    public GameObject[] healtUI;
    public GameObject screenUI;


    void Takedemage()
    {
        healt--;
        if (healt <= 0)
        {
            healt = 0;
            PlayerLose();


        }
        healtUI[healt].SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bolaaa"))
        {
            Takedemage();
        }
    }
    void PlayerLose()
    {
        screenUI.SetActive(true);
        Time.timeScale = 0;
    }
}
