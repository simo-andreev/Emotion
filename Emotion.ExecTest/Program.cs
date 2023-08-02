﻿#region Using

using System.Numerics;
using System.Threading.Tasks;
using Emotion.Common;
using Emotion.Game.World2D;
using Emotion.Game.World2D.SceneControl;
using Emotion.Graphics;
using Emotion.Primitives;
using Emotion.Testing;
using Emotion.Utility;

#endregion

namespace Emotion.ExecTest;

public class Program
{
	private static void Main(string[] args)
	{
		if (CommandLineParser.FindArgument(args, "tests", out string _))
		{
			MainTests(args);
			return;
		}

		var config = new Configurator
		{
			DebugMode = true
		};

		Engine.Setup(config);

		if (CommandLineParser.FindArgument(args, "3d", out string _))
			Engine.SceneManager.SetScene(new TestScene3D());
		else
			Engine.SceneManager.SetScene(new TestScene2D());

		Engine.Run();
	}

	private static void MainTests(string[] args)
	{
		var config = new Configurator
		{
			DebugMode = true
		};

		Engine.Setup(config);
		TestExecutor.ExecuteTests(args, config);
		Engine.Run();
	}
}

public class TestScene3D : World2DBaseScene<Map2D>
{
	public override Task LoadAsync()
	{
		_editor.EnterEditor();
		return Task.CompletedTask;
	}

	public override void Draw(RenderComposer composer)
	{
		composer.SetUseViewMatrix(false);
		composer.RenderSprite(Vector3.Zero, composer.CurrentTarget.Size, Color.CornflowerBlue);
		composer.ClearDepth();
		composer.SetUseViewMatrix(true);

		base.Draw(composer);
	}
}

public class TestScene2D : World2DBaseScene<Map2D>
{
	public override Task LoadAsync()
	{
		_editor.EnterEditor();
		return Task.CompletedTask;
	}

	public override void Draw(RenderComposer composer)
	{
		composer.SetUseViewMatrix(false);
		composer.RenderSprite(Vector3.Zero, composer.CurrentTarget.Size, Color.CornflowerBlue);
		composer.ClearDepth();
		composer.SetUseViewMatrix(true);

		base.Draw(composer);
	}
}