using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour {

	public List<int> set1;
	public List<GameObject> set2;
	//UnionAlgorithm k0;
	// Use this for initialization
	void Start () {
		set1 = new List<int>();
		set2 = new List<GameObject>();


		//add red,purple,blue
		set1.Add (0);
		set1.Add (1);
		set1.Add (2);

		makeSet2 (ref set1, ref set2);
	


		print ("what in set2 after makeSet2 function");
		foreach(GameObject value in set2)
			print (value.name);
	}


	void makeSet2(ref List<int> set1, ref List<GameObject> set2)
	{
		GameObject e0 = GameObject.Find ("red");
		GameObject e1 = GameObject.Find ("purple");
		GameObject e2 = GameObject.Find ("blue");
		GameObject e3 = GameObject.Find ("green");
		GameObject e4 = GameObject.Find ("yellow");
		GameObject e5 = GameObject.Find ("orange");
		GameObject e6 = GameObject.Find ("black");

		for(int i = 0;i<set1.Count;i++)
		{
			int choice = set1[i];
			switch(choice)
			{
			case 0:
				set2.Add (e0);
				break;
			case 1:
				set2.Add (e1);
				break;
			case 2:
				set2.Add (e2);
				break;
			case 3:
				set2.Add (e3);
				break;
			case 4:
				set2.Add (e4);
				break;
			case 5:
				set2.Add (e5);
				break;
			case 6:
				set2.Add (e6);
				break;
				
			}
			
		}
	}

}
