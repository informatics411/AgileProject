using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IGameService
{
    Task<bool> RegisterGameAsync(GameRegister model);
    Task<GameDetail> GetGameDetailAsync(string name);
}