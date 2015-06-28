using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1HpScripts : MonoBehaviour {
	Slider _slider;

	// Use this for initialization
	void Start () {
		_slider = GameObject.Find("Player1Slider").GetComponent<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		if(Public.pattern == 2){

		Public._hp1 += 1f;
		if(Public._hp1 >= 35){
			Public._hp1 += 0.8f;
		}
		if(Public._hp1 >= 50){
			Public._hp1 += 0.8f;
		}
		if(Public._hp1 >= 80f){
			Public._hp1 += 1f;
		}
		if(Public._hp1 > _slider.maxValue){
			Public._hp1 = _slider.minValue;
		}
		
		_slider.value = Public._hp1;
		if(Input.GetKeyDown("f")){
		Public.pattern = 3;
	}
	}
	}
}