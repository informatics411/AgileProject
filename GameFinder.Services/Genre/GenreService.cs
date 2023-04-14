using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class GenreService : IGenreService
{
    private readonly ApplicationDbContext _context;
    public GenreService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterGenreAsync(GenreRegister model)
    {
        var entity = new GenreEntity
        {
            Name = model.Name
        };

        _context.Genres.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

}
