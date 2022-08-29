using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
	public GameObject muncul; //kordinat muncul memakai gameobject diinput
	public GameObject Ball;  // diinput bolanya
	GameObject bola;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(10, 10, 100, 200)); //membuat ui tombol
		if (GUILayout.Button("Tambah Bola"))
		{
			GameObject temp = (GameObject)
				GameObject.Instantiate(Ball, muncul.transform.position, muncul.transform.rotation);
			Destroy(temp, 4);
		}
		GUILayout.EndArea();
	}
}