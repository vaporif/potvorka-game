using Godot;

public partial class MainMenu : Node
{
	public void _on_start_pressed() =>
		GetTree().ChangeSceneToFile("res://levels/level-1.tscn");

	public void _on_quit_pressed() => GetTree().Quit();
}
