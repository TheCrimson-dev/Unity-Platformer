//Script allows the camera to follow the character


var Target : Transform;
var Distance : float = 5;
var CameraY : float = 3;


function Update() {
    
     transform.position.x = Target.position.x;
}


function LateUpdate() {
   GetComponent.<Camera>().main.transform.position.y = CameraY;  

}