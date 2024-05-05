using Godot;
using System;

public partial class GameManager : Node
{
	private int _points = 0;
  private Label _label;
  public override void _Ready()
  {
    _label = GetNode<Label>("%PointsLabel");
  }


	public void AddPoint() {
		_points+=1;
    _label.Text = $"Dubasik: {_points}";
	}
}
