using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Scripts : MonoBehaviour {
	public Rigidbody rb;
	private Renderer _renderer;
	private GameObject _child;

	// Use this for initialization
	void Start () {
		_child = this.transform.Find("Player1direction").gameObject;
		_renderer = _child.GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody>();
		Public._hp1 = 0f;
		Public._hp2 = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Public.pattern);
		if(Input.GetKeyDown("a")){
		Public.pattern = 1;
		}
		if(Public.pattern == 1){

		_renderer.enabled = true;

		transform.Rotate(0,2,0);
		if(Input.GetKeyDown("d")){
			Public.pattern = 2;
			_renderer.enabled = false;
		}
	}

		if(Public.pattern == 3){
			if(Input.GetKeyDown("j")){
				Public.pattern = 7;
			}
		}
		if(Public.pattern == 7){

			Public._hp1 *= 0.1f;
			rb.AddForce(transform.forward * Public._hp1);

			if(Input.GetKeyDown("space")){
				Public.pattern = 4;
			}
		}
	}

	

}
