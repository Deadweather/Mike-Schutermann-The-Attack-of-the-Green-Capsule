#pragma strict

private var startTime : float;
var textTime : String;

function Start () {

	startTime = Time.time;

}

function OnGUI () {

	var guiTime = Time.time - startTime;

	var minutes : int = guiTime / 60;
	var seconds : int = guiTime % 60;
	var fraction : int = (guiTime * 100) % 100;

	textTime = String.Format ("{0:00} : {1:00} : {2:00}" , minutes, seconds, fraction);
	GetComponent(UI.Text).text = textTime;

}