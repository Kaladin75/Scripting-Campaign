using System.Collections;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
	int myInt = 5;
	string myName = "Dylan Kennedy";

	void Start(){
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
		printTextConsole ("hjoasdvjoaehrvgf");
 	}

	int MultiplyByTwo(int number){
		int ret;

		ret = number * 2;

		return ret;


	}

	void printTextConsole (string textToPrint){
		Debug.Log (textToPrint);
	}





 }