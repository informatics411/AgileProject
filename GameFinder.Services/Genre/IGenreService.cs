using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public interface IGenreService
{
    Task<bool> RegisterGenreAsync(GenreRegister model);
}
