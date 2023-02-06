using Godot;
using System;

public class Sprite : Godot.Sprite
{
	vector2 direction;
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta){
		direction.x = Input.GetActioStrength("move_left")-Input.GetActioStrength("move_left");

	}
}
