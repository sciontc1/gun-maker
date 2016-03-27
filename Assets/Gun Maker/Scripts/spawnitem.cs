using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class spawnitem : MonoBehaviour,IPointerUpHandler 
{

	public string item;
	public int wRes;
	public int hRes;

	// Use this for initialization
	void Start () 
	{
		wRes = Screen.width;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}


	public void OnPointerUp(PointerEventData eventData)
	{

		GameObject m4 = Instantiate(Resources.Load(item)) as GameObject;
		//Dropdown.csisOpen = false;


		

		//GameObject ddbox = GameObject.Find("Container");
		//DropDown dropdown = ddbox.GetComponent<DropDown>();
		RifDropDown.isOpen = false;

	}

	
}