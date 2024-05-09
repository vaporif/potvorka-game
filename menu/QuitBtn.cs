public partial class QuitBtn : Godot.Button
{
	public void _on_pressed() => GetTree().Quit();
}
