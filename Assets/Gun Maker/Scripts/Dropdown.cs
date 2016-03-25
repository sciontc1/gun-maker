using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Dropdown : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerUpHandler, IPointerDownHandler, IPointerClickHandler{

	public RectTransform container;
	public bool isOpen;
	public bool selected;


	// Use this for initialization
	void Start () 
	{
		container = transform.FindChild ("Container").GetComponent<RectTransform>();
		isOpen = false;
		selected = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isOpen) 
		{
			Vector3 scale = container.localScale;
			scale.y = Mathf.Lerp(scale.y, 1, Time.deltaTime *12);
			container.localScale = scale;
		}
		else
		{
			Vector3 scale = container.localScale;
			scale.y = Mathf.Lerp(scale.y, 0, Time.deltaTime *12);
			container.localScale = scale;
		}

	
	}




	public void OnPointerEnter(PointerEventData eventData)
	{
		//isOpen = true;
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		//isOpen = false;
	}
	public void OnPointerDown(PointerEventData eventData)
	{	
		
		//isOpen = true;
		
	}
	public void OnPointerUp(PointerEventData eventData)
	{	
		
		//isOpen = false;
		
	}

	public void OnPointerClick(PointerEventData eventData)
	{	
		
		isOpen = true;
		
	}

}
