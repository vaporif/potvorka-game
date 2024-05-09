using Godot;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

public partial class LoadMenu : Godot.Node2D
{
    public override void _Ready()
	{
		Task.Run(async () =>
		{
			await Task.Delay(2000);
			GetTree().CallDeferred(SceneTree.MethodName.ChangeSceneToFile, "res://menu.tscn");
		});
	}
}
