using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public interface IRepository
  {
    void Add();
  }

  public class Repository : IRepository
  {
    public void Add()
    {
      //adiciona item
    }
  }

  public class Implementacao
  {
    public void Proccess()
    {
      var repository = new Repository();
      repository.Add();
    }
  }

  public class Abstracao
  {
    private readonly IRepository _repository;

    public Abstracao(IRepository repository)
    {
      _repository = repository;
    }

    public void Proccess()
    {
      _repository.Add();
    }
  }
}
