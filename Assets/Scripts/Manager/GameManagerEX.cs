using static Define;
using System;

[Serializable]
public class GameData
{
    public string Name;
    public PlayerClassType PlayerClass;
}

public class GameManagerEX
{
    GameData _gameData = new GameData();

    #region 스탯
    public string Name
    {
        get { return _gameData.Name; }
        set { _gameData.Name = value; }
    }

    public PlayerClassType Class
    {
        get { return _gameData.PlayerClass; }
        set { _gameData.PlayerClass = value; }
    }
    #endregion

    public void Init()
    {
        Name = "Player";
        Class = PlayerClassType.Penguin;
    }
}