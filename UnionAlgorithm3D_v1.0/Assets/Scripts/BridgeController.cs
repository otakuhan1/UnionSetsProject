using UnityEngine;
using System.Collections;

public class BridgeController : MonoBehaviour {
	public GameObject southwall_1;
	public GameObject northwall_0;
	public GameObject Bridge_0;
	// Use this for initialization
	void Start () {
		southwall_1.SetActive (true);
		northwall_0.SetActive (true);
		Bridge_0.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(UnionAction.katana0isDestroyed == 1){
			southwall_1.SetActive (false);
			northwall_0.SetActive (false);
			Bridge_0.SetActive (true);
		}
	}
}
