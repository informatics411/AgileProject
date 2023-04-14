using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GameService : IGameService
{
    private readonly ApplicationDbContext _context;
    public GameService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> RegisterGameAsync(GameRegister model)
    {
        var entity = new GameEntity
        {
            Name = model.Name,
            GameSystemID = model.GameSystemID,
            GenreID = model.GenreID
        };

        _context.Games.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<GameDetail> GetGameDetailAsync(string name)
    {
        var entity = await _context.Games.FindAsync(name);
        if (entity == null)
        {
            return null;
        }
        var gameDetail = new GameDetail
        {
            Id = entity.Id,
            Name = entity.Name,
            GameSystemID = entity.GameSystemID,
            GenreID = entity.GenreID
        };
        return gameDetail;
    }
}