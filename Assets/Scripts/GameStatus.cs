using System.Collections;
using System.Collections.Generic;

public class GameStatus
{
    public enum GameStat
    {
        start,
        start_pressed,
        play,
        inGameMenu,
        resume,
        win,
    }
    public GameStat status;
    public GameStatus()
    {
        status = GameStat.start;
        

    }
}