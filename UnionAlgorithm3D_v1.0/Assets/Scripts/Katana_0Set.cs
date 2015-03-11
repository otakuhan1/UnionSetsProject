﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Katana_0Set : MonoBehaviour {
	public float radius = 1f;
	public GameObject center;
	

	private int sizeOfSet;
	
	//list store numbers
	public List<int> katana_0Set1 = new List<int>();
	//depending on the values in set1, generate corresponding elements in set2
	public List<GameObject> katana_0Set2 = new List<GameObject> ();
	
	//GameObject follower = new GameObject();
	// Use this for initialization
	void Start () {

		GameObject e0 = GameObject.Find ("red");
		GameObject e1 = GameObject.Find ("purple");
		GameObject e2 = GameObject.Find ("blue");
		GameObject e3 = GameObject.Find ("green");
		GameObject e4 = GameObject.Find ("yellow");
		GameObject e5 = GameObject.Find ("orange");
		GameObject e6 = GameObject.Find ("black");

		//set the size of the set
		//the size of this set is from 0 to 7
		sizeOfSet = Random.Range (0, 7);
		//Debug.Log ("this sets size is "+sizeOfSet);
		
		//generate unique random numbers for the set
		//you can have empty set
		for(int i = 0; i < sizeOfSet; i++)
		{
			//the random int generated has 7 options
			int randomInt = Random.Range (0,6);
			while(katana_0Set1.Contains(randomInt))
			{
				randomInt = Random.Range (0,6);
			}
			katana_0Set1.Add (randomInt);
			//Instantiate(ele,follower.transform.position,follower.transform.rotation);
		}
		
		//add corresponding elements to set2
		for(int i = 0;i<sizeOfSet;i++)
		{
			int choice = katana_0Set1[i];
			switch(choice)
			{
			case 0:
				katana_0Set2.Add (e0);
				break;
			case 1:
				katana_0Set2.Add (e1);
				break;
			case 2:
				katana_0Set2.Add (e2);
				break;
			case 3:
				katana_0Set2.Add (e3);
				break;
			case 4:
				katana_0Set2.Add (e4);
				break;
			case 5:
				katana_0Set2.Add (e5);
				break;
			case 6:
				katana_0Set2.Add (e6);
				break;
				
			}
			
		}
		
		for (int i = 0; i < sizeOfSet; i++) {
			//instantiate elements in set2 at some random position
			
			katana_0Set2[i] = (GameObject) Instantiate (katana_0Set2[i],new Vector3 (i,i,0),transform.rotation);
			
			float angle = i * Mathf.PI * 2 / sizeOfSet;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0.5f, Mathf.Sin(angle)) * radius + center.transform.position ;
			katana_0Set2[i].transform.position = pos;
			katana_0Set2[i].transform.parent = center.transform;
			
		}
	}

	// Update is called once per frame
	void Update () {
		center.transform.position = transform.position;
		if(UnionAction.katana0isDestroyed == 1){
			//Debug.Log("katana 0 is destroyed");
			for (int i = 0; i < sizeOfSet; i++)
			{
				katana_0Set2[i].gameObject.SetActive(false);
			}
		}
	}
}