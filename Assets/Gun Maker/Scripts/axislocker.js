var lockZ:float;
function Update ()
{
//currentZ = this.transform.position.z;
print(lockZ);


//Y AXIS//
if(this.transform.position.y <= 82)
{
	transform.position.y = 82;
}

if(this.transform.position.y >= 200)
{
	transform.position.y = 200;
}
  
    
//X AXIS//
if(this.transform.position.x <= -320)
{
	transform.position.x = -320;
}
if(this.transform.position.x >= -19)
{
	transform.position.x = -19;
}
    
  
//Z AXIS// 
if(this.transform.position.z <= lockZ)
{
	transform.position.z = lockZ;
}
if(this.transform.position.z >= lockZ)
{
	transform.position.z = lockZ;
}


}