using Godot;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

public partial class Sprite2D : Godot.Sprite2D
{
    // Called when the node enters the scoene tree for the first time.
    public override void _Draw()
    {
        base._Draw();
    }
    public override void _Ready()
	{
			Task.Run(async () =>
			{
				await Task.Delay(2000);
				GetTree().CallDeferred(SceneTree.MethodName.ChangeSceneToFile, "res://menu.tscn");
			});
	}
}
