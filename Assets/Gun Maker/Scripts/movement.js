#pragma strict
 
private  var screenPoint:Vector3;
private  var offset:Vector3;


function  OnMouseDown()
{
screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
}
 
function OnMouseDrag() 
{
var curScreenPoint:Vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
var curPosition:Vector3   = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
transform.position = curPosition;
}