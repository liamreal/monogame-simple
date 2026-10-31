using System;
using ecs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_simple;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D playerSprite;
    private Texture2D enemySprite;
    private Texture2D backgroundSprite;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        enemySprite = Content.Load<Texture2D>("turtle");
        playerSprite = Content.Load<Texture2D>("jellyfish");
        backgroundSprite = Content.Load<Texture2D>("sea");


        Entity entity = new Entity(1, Tag.PLAYER);
        // Console.WriteLine(entity.GetId());

        // throw new Exception("INTENTIONAL ERROR");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        _spriteBatch.Draw(backgroundSprite, new Vector2(0, 0), Color.Blue);
        _spriteBatch.Draw(enemySprite, new Vector2(0, 0), Color.Red);
        _spriteBatch.Draw(playerSprite, new Vector2(0, 0), Color.Wheat);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
