using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Scripts : MonoBehaviour {
	public Rigidbody rb;
	private Renderer _renderer;
	private GameObject _child;


	// Use this for initialization
	void Start () {
		_child = this.transform.Find("Player2direction").gameObject;
		_renderer = _child.GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Public.pattern == 4){

		_renderer.enabled = true;

		transform.Rotate(0,2,0);
		if(Input.GetKeyDown("d")){
			Public.pattern = 5;
			_renderer.enabled = false;
		}
	}

		if(Public.pattern == 6){
			if(Input.GetKeyDown("j")){
				Public.pattern = 8;
			}
		}

		if(Public.pattern == 8){
			Public._hp2 *= 0.1f;
			rb.AddForce(transform.forward * Public._hp2);

			if(Input.GetKeyDown("space")){
				Public.pattern = 1;
			}
		}


	}

}
