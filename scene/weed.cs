using Godot;
using System;

public partial class weed : Area2D
{
  private GameManager _manager;
  public override void _Ready()
  {
    _manager = GetNode<GameManager>("%GameManager");
  }

  private void _on_body_entered(CollisionObject2D body)
  {
    if (body.Name == "Player")
    {
      _manager.AddPoint();
      QueueFree();
    }
  }
}
