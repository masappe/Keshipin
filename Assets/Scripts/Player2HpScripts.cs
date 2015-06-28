using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2HpScripts : MonoBehaviour {
	Slider _slider;

	// Use this for initialization
	void Start () {
		_slider = GameObject.Find("Player2Slider").GetComponent<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		if(Public.pattern == 5){
		Public._hp2 += 1;
		if(Public._hp2 >= 35){
			Public._hp2 += 0.8f;
		}
		if(Public._hp2 >= 50){
			Public._hp2 += 0.8f;
		}
		if(Public._hp2 >= 80f){
			Public._hp2 += 1f;
		}

		
		if(Public._hp2 > _slider.maxValue){
			Public._hp2 = _slider.minValue;
		}
		
		_slider.value = Public._hp2;
		if(Input.GetKeyDown("f")){
			Public.pattern = 6;
			}
		}
	}
}