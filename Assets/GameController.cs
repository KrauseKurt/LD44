using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController
{
    #region VARIABLES
    /// <summary>
    /// Counts in-game
    /// </summary>
    public int Hearts, Coins, WaveEnemies, PowerDamage;

    /// <summary>
    /// 4 life equals 1 heart
    /// </summary>
    public float Life;

    /// <summary>
    /// Wave that player stay playing
    /// </summary>
    public int CurrentWave;

    public Player Player;
    public HUDController Hud;

    private static GameController _instance;
    public static GameController Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameController();
            return _instance;
        }
    }

    #endregion

    #region Unity Events

    #endregion

    #region METHODS

    /// <summary>
    /// Decrement life
    /// </summary>
    /// <returns></returns>
    public bool DecLife()
    {
        if (Life - 1 > 0)
        {
            Life -= 1;

            if (Life % 4 == 0)
                DecHeart();

            Hud.HeartsManager();
            return true; // Stop method here if can dec
        }

        CallGameOver();
        return false;
    }

    /// <summary>
    /// Decrement life
    /// </summary>
    /// <returns></returns>
    public bool DecHeart()
    {
        if (Hearts - 1 > 1)
        {
            Hearts -= 1;

            Hud.HeartsManager();
            return true; // Stop method here if can dec
        }

        CallGameOver();
        return false;
    }

    /// <summary>
    /// Call GameOver and restar game
    /// </summary>
    private void CallGameOver()
    {
        throw new NotImplementedException();
    }
    #endregion
}
