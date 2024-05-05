using Godot;
using System;

public partial class Button : Godot.Button
{
	public void _on_pressed() {
		GetTree().ChangeSceneToFile("res://levels/level-1.tscn");
	}
}
