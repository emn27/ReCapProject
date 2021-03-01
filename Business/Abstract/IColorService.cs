using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
