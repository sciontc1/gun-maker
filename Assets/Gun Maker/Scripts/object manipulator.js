var selected = false;
var keypress : GUIText;


function OnMouseDown()
{
    //transform.position.x -= 10;
    if(selected == true)
    {
     selected = false;
    }
    selected = true;
    print("clicked");
//    keypress.text = ("left click down");
    
}

function OnMouseUp()
{
selected = false;
//keypress.text = ("left click up");
}




function Update()
{

if(Input.GetKeyDown("escape"))
{
//keypress.text = ("escape");
	Application.Quit();
}
    
if (selected == true)
{

	
//print("is selected");
 	if(Input.GetKeyDown("a"))
	{
		transform.position.x += 1;
    	//transform.position = Vector3(0, 0, 0);
    }
    if(Input.GetKeyDown("d"))
	{
		transform.position.x -= 1;
    	//transform.position = Vector3(0, 0, 0);
    }
    if(Input.GetKeyDown("w"))
	{
		transform.position.y += 1;
    	//transform.position = Vector3(0, 0, 0);
    }
    if(Input.GetKeyDown("s"))
	{
		transform.position.y -= 1;
    	//transform.position = Vector3(0, 0, 0);
    }
    
    
    if(Input.GetKeyDown("delete"))
	{
		Destroy (gameObject);
		//keypress.text = ("delete");
    }
    if(Input.GetKeyDown("backspace"))
	{
		Destroy (gameObject);
		//keypress.text = ("backspace");

    }
    
    
    
    if(Input.GetKeyDown("="))
	{
	//this is an equal sign as to use the + sign the shift key must be held and fuck that
		transform.localScale += Vector3(0.5,0.5,0.5);
		//keypress.text = ("=");
    }
    
    if(Input.GetKeyDown("-"))
	{
		transform.localScale -= Vector3(0.5,0.5,0.5);
		//keypress.text = ("-");
	}
    
    
  
}
}