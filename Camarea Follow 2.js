//This script will allow your camera to follow the rocket


var Target : Transform;
var Distance : float = 5;
var CameraY : float = 3;


function Update() {
    
     transform.position.x = Target.position.x;
     transform.position.y = Target.position.y;
}
