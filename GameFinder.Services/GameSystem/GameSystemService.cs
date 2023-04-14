using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GameSystemService : IGameSystemService
{
    private readonly ApplicationDbContext _context;
    public GameSystemService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> RegisterGameSystemAsync(GameSystemRegister model)
    {
        var entity = new GameSystemEntity
        {
            Name = model.Name
        };

        _context.GameSystems.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }
}