using Godot;

public partial class main_character : CharacterBody2D
{
  public const float Speed = 400.0f;
  public const float JumpVelocity = -900.0f;
  private AnimatedSprite2D sprite_2d;

  public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
  public override void _Ready()
  {
    sprite_2d = GetNode<AnimatedSprite2D>("Sprite2D");
  }

  public override void _PhysicsProcess(double delta)
  {
    if (Velocity.X != 0) {
      sprite_2d.Animation = "running";
    }
    else if(IsOnFloor()) 
    {
      sprite_2d.Animation = "default";
    }

    Vector2 velocity = Velocity;

    if (!IsOnFloor())
    {
      velocity.Y += gravity * (float)delta;
    }

    if (Input.IsActionPressed("jump") && IsOnFloor())
    {
      velocity.Y = JumpVelocity;
      sprite_2d.Animation = "jumping";
    }

    float direction = Input.GetAxis("left", "right");
    if (direction != 0)
    {
      velocity.X = direction * Speed;
    }
    else
    {
      velocity.X = Mathf.MoveToward(Velocity.X, 0, 40);
    }

    Velocity = velocity;
    MoveAndSlide();
    if (velocity.X != 0)
    {
      var isLeft = velocity.X < 0;
      sprite_2d.FlipH = isLeft;
    }
  }
}
