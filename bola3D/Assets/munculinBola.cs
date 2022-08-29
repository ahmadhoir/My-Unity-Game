using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculinBola : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bolaa;
    public float minX, maxX;
    public float minTime, maxTime;
    void Start()
    {
        StartCoroutine(munculin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator munculin()
    {
        
        yield return new WaitForSeconds(Random.Range(minTime,maxTime));
        GameObject temp = (GameObject)
        GameObject.Instantiate(bolaa, transform.position + Vector3.right * Random.Range(minX, maxX), Quaternion.identity);
        StartCoroutine(munculin());
        Destroy(temp, 9);
    }
   

}
