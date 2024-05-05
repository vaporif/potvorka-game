using Godot;
using System;

public partial class yoba : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_body_entered(CollisionObject2D body)
	{
		if (body.Name == "Player")
		{
			GetTree().CallDeferred(SceneTree.MethodName.ChangeSceneToFile, "res://scene/win.tscn");
		}
	}
}
